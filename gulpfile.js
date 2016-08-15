'use strict';

var fs = require('fs');
var gulp = require('gulp');
var $ = require('gulp-load-plugins')();
var request = require('request');
var parseString = require('xml2js').parseString;
var path = require('path');

var isOnTravis = process.env.CIRCLECI === 'true';
var artifactsDir = process.env.CIRCLE_ARTIFACTS;
var isOnTravisAndMaster = isOnTravis && process.env.CI_PULL_REQUEST === '' && process.env.CIRCLE_BRANCH === 'master';
var version;

var isWindows = /^win/.test(process.platform);
var nugetCmd = isWindows ? 'resources/nuget-3.4.4.exe' : 'mono resources/nuget-3.4.4.exe';
var legacyNugetCmd = isWindows ? 'resources/nuget-2.8.6.exe' : 'mono resources/nuget-2.8.6.exe';
var compileCmd = isWindows ? 'csc' : 'mcs -sdk:4.5';

var docsUrl = 'http://secxbrl-24-2-2.28.io/v1/_queries/public/api/docs';
//var docsUrl = 'https://www.dropbox.com/s/5v43dzjmxef0a9e/swagger-fully-resolved.json?dl=1';
//var docsUrl = 'http://secxbrl-3.28.io/v1/_queries/public/api/docs';

var cellstoreFolder = '~/cellstore/cellstore-pro';
var swaggerCodegenFolder = '~/cellstore/swagger-codegen';
var swaggerCodegenVersion = '2.7.0';

var cellstore_nuspec;
parseString(fs.readFileSync('resources/CellStore.dll.nuspec', 'utf-8'), { async: false }, function (err, result) {
    cellstore_nuspec = result;
    version = result.package.metadata[0].version[0];
});

gulp.task('swagger:clean', $.shell.task([
    'rm -rf build',
    'mkdir build',
    'rm -rf build-resources',
    'mkdir build-resources',
    'rm -rf build-binary',
    'mkdir build-binary'
]));

gulp.task('swagger:resolve', ['swagger:clean'], function(done){
    request({ url: docsUrl }, function(err, resp){
        fs.writeFileSync('build-resources/swagger.json', resp.body);
        done();
    });
});

gulp.task('swagger:resolve-dev', ['swagger:clean'], $.shell.task([
  'cd ' + cellstoreFolder + ' && gulp swagger:resolve',
  'cp ' + cellstoreFolder + '/swagger/swagger-remotes-resolved.json build-resources/swagger.json'
]));

gulp.task('swagger:resolve-repository', ['swagger:clean'], $.shell.task([
  'cp swagger/swagger.json build-resources/swagger.json'
]));

gulp.task('swagger:install-codegen', $.shell.task(
  'cd build-resources && curl --retry-delay 0 --retry-max-time 600 --retry 5 --max-time 60 -L -o swagger-codegen-cli.jar https://github.com/28msec/swagger-codegen/releases/download/v' + swaggerCodegenVersion + '/swagger-codegen-cli.jar'
));

gulp.task('swagger:install-codegen-dev', $.shell.task([
  'cd ' + swaggerCodegenFolder + ' && mvn clean && mvn package',
  'cp ' + swaggerCodegenFolder + '/modules/swagger-codegen-cli/target/swagger-codegen-cli.jar build-resources/swagger-codegen-cli.jar'
]));

gulp.task('swagger:generate-csharp', $.shell.task([
    'cp resources/codegen-options.json build-resources',
    'java -DnoInlineModels -jar build-resources/swagger-codegen-cli.jar generate -i build-resources/swagger.json -l cellstore-csharp -c build-resources/codegen-options.json  -o build'
]));

gulp.task('swagger:csharp', $.shell.task([
    path.normalize(nugetCmd + ' install build/src/CellStore/packages.config -o build-resources/dependencies'),
    'mkdir -p build-binary/lib',
    'cp build-resources/dependencies/Newtonsoft.Json.8.0.3/lib/net45/Newtonsoft.Json.dll build-binary/lib/Newtonsoft.Json.dll',
    'cp build-resources/dependencies/RestSharp.105.1.0/lib/net45/RestSharp.dll build-binary/lib/RestSharp.dll',
    path.normalize(compileCmd + ' -r:build-binary/lib/Newtonsoft.Json.dll,build-binary/lib/RestSharp.dll,System.Runtime.Serialization.dll -target:library -out:build-binary/CellStore.dll -recurse:build/src/CellStore/*.cs -doc:build-binary/CellStore.xml -platform:anycpu'),
]));

gulp.task('swagger:test', $.shell.task([
    path.normalize(compileCmd + ' -r:build-binary/lib/Newtonsoft.Json.dll,build-binary/lib/RestSharp.dll,build-binary/CellStore.dll,System.Runtime.Serialization.dll -out:samples/GetFacts/GetFacts/Program.exe samples/GetFacts/GetFacts/Program.cs'),
    path.normalize(compileCmd + ' -r:build-binary/lib/Newtonsoft.Json.dll,build-binary/lib/RestSharp.dll,build-binary/CellStore.dll,System.Runtime.Serialization.dll -out:samples/AddFacts/AddFacts/Program.exe samples/AddFacts/AddFacts/Program.cs'),
    path.normalize(compileCmd + ' -r:build-binary/lib/Newtonsoft.Json.dll,build-binary/lib/RestSharp.dll,build-binary/CellStore.dll,System.Runtime.Serialization.dll -out:samples/AddArchives/AddArchives/Program.exe samples/AddArchives/AddArchives/Program.cs'),
    'cp build-binary/lib/*.dll samples/GetFacts/GetFacts',
    'cp build-binary/*.dll samples/GetFacts/GetFacts',
    isWindows ? 'cd samples/GetFacts/GetFacts && Program.exe' : 'mono samples/GetFacts/GetFacts/Program.exe'
]));

gulp.task('swagger:pack', $.shell.task([
    'cp resources/CellStore.dll.nuspec build-binary',
    legacyNugetCmd + ' pack build-binary/CellStore.dll.nuspec'
]));

gulp.task('swagger:push', $.shell.task([
    'sudo ' + nugetCmd + ' push CellStore.NET.' + version + '.nupkg -Source nuget.org -ApiKey ' + process.env.NUGET_API_KEY    
]));

gulp.task('swagger:copy', $.shell.task([
    artifactsDir ? 'cd build && cp -R * ' + artifactsDir : 'echo "CIRCLE_ARTIFACTS not set"'
]));

gulp.task('swagger', function(done){
    $.runSequence('swagger:resolve', 'swagger:install-codegen', 'swagger:generate-csharp', 'swagger:csharp', 'swagger:test', 'swagger:pack', 'swagger:copy', function(){
        if(isOnTravisAndMaster) {
            $.runSequence('swagger:push', done);
        } else {
            done();
        }
    });
});

gulp.task('swagger-repository', function(done){
    $.runSequence('swagger:resolve-repository', 'swagger:install-codegen', 'swagger:generate-csharp', 'swagger:csharp', 'swagger:test', 'swagger:pack', 'swagger:copy', function(){
        if(isOnTravisAndMaster) {
            $.runSequence('swagger:push', done);
        } else {
            done();
        }
    });
});


gulp.task('swagger-dev', function(done){
        if(isOnTravis)
          throw 'This task cannot be run on the PQ';
        $.runSequence('swagger:resolve-dev', 'swagger:install-codegen-dev', 'swagger:generate-csharp', 'swagger:csharp', 'swagger:test', 'swagger:pack', 'swagger:copy', done);  
});

gulp.task('default', ['swagger']); //Use released swagger-codegen and documentation
//gulp.task('default', ['swagger-repository']); //Use released swagger-codegen and documentation committed in this repository
//gulp.task('default', ['swagger-dev']); //Use local swagger-codegen and documentation
