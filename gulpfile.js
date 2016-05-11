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
var nugetCmd = isWindows ? 'build-resources/nuget' : 'mono build-resources/nuget.exe';
var compileCmd = isWindows ? 'csc' : 'mcs -sdk:4.5';

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

//GITHUB
gulp.task('swagger:resolve', ['swagger:clean'], function(done){
    request({ url: 'http://28msec.github.io/cellstore-pro/swagger-aggregated.json' }, function(err, resp){
        fs.writeFileSync('build-resources/swagger-aggregated.json', resp.body);
        done();
    });
});

//GITHUB
//gulp.task('swagger:install-codegen', ['swagger:resolve'], $.shell.task(
//    'cd build-resources && curl --retry-delay 0 --retry-max-time 600 --retry 5 --max-time 60 -L -o swagger-codegen-cli.jar https://github.com/28msec/swagger-codegen/releases/download/v2.5.3/swagger-codegen-cli.jar'
//));

//LOCAL
//gulp.task('swagger:resolve', ['swagger:clean'], $.shell.task([
//  'cd ~/cellstore/cellstore-pro && gulp swagger:resolve',
//  'cp ~/cellstore/cellstore-pro/swagger/swagger-aggregated.json build-resources/swagger-aggregated.json'
//]));

//LOCAL
gulp.task('swagger:install-codegen', ['swagger:resolve'], $.shell.task(
  'cp ~/cellstore/swagger-codegen/modules/swagger-codegen-cli/target/swagger-codegen-cli.jar build-resources/swagger-codegen-cli.jar'
));

gulp.task('swagger:generate-csharp', ['swagger:install-codegen'], $.shell.task([
    'cp resources/codegen-options.json build-resources',
    'java -DnoInlineModels -jar build-resources/swagger-codegen-cli.jar generate -i build-resources/swagger-aggregated.json -l cellstore-csharp -c build-resources/codegen-options.json  -o build'
]));

gulp.task('swagger:csharp', ['swagger:generate-csharp'], $.shell.task([
    isWindows ? ':' : 'wget https://nuget.org/nuget.exe -O build-resources/nuget.exe',
    isWindows ? ':' : 'mozroots --import --sync',
    path.normalize(nugetCmd + ' install build/src/CellStore/packages.config -o build-resources/dependencies'),
    'mkdir -p build-binary/lib',
    'cp build-resources/dependencies/Newtonsoft.Json.8.0.2/lib/net45/Newtonsoft.Json.dll build-binary/lib/Newtonsoft.Json.dll',
    'cp build-resources/dependencies/RestSharp.105.1.0/lib/net45/RestSharp.dll build-binary/lib/RestSharp.dll',
    path.normalize(compileCmd + ' -r:build-binary/lib/Newtonsoft.Json.dll,build-binary/lib/RestSharp.dll,System.Runtime.Serialization.dll -target:library -out:build-binary/CellStore.dll -recurse:build/src/CellStore/*.cs -doc:build-binary/CellStore.xml -platform:anycpu'),
]));

gulp.task('swagger:test', $.shell.task([
    path.normalize(compileCmd + ' -r:build-binary/lib/Newtonsoft.Json.dll,build-binary/lib/RestSharp.dll,build-binary/CellStore.dll,System.Runtime.Serialization.dll -out:samples/GetFacts/GetFacts/Program.exe samples/GetFacts/GetFacts/Program.cs'),
    path.normalize(compileCmd + ' -r:build-binary/lib/Newtonsoft.Json.dll,build-binary/lib/RestSharp.dll,build-binary/CellStore.dll,System.Runtime.Serialization.dll -out:samples/AddFacts/AddFacts/Program.exe samples/AddFacts/AddFacts/Program.cs'),
    path.normalize(compileCmd + ' -r:build-binary/lib/Newtonsoft.Json.dll,build-binary/lib/RestSharp.dll,build-binary/CellStore.dll,System.Runtime.Serialization.dll -out:samples/AddFiling/AddFiling/Program.exe samples/AddFiling/AddFiling/Program.cs'),
    'cp build-binary/lib/*.dll samples/GetFacts/GetFacts',
    'cp build-binary/*.dll samples/GetFacts/GetFacts',
    isWindows ? 'cd samples/GetFacts/GetFacts && Program.exe' : 'mono samples/GetFacts/GetFacts/Program.exe'
]));

gulp.task('swagger:pack', $.shell.task([
    'cp resources/CellStore.dll.nuspec build-binary',
    isWindows ? ':' : 'wget https://nuget.org/nuget.exe -O build-resources/nuget.exe',
    nugetCmd + ' pack build-resources/CellStore.dll.nuspec'
]));

gulp.task('swagger:push', $.shell.task([
    'sudo ' + nugetCmd + ' setApiKey ' + process.env.NUGET_API_KEY + ' | cat &> /dev/null',
    'sudo ' + nugetCmd + ' push CellStore.NET.' + version + '.nupkg'
]));

gulp.task('swagger:copy', $.shell.task([
    artifactsDir ? 'cd build && cp -R * ' + artifactsDir : 'echo "CIRCLE_ARTIFACTS not set"'
]));

gulp.task('swagger', function(done){
    $.runSequence('swagger:csharp', 'swagger:test', 'swagger:pack', 'swagger:copy', function(){
        if(isOnTravisAndMaster) {
            $.runSequence('swagger:push', done);
        } else {
            done();
        }
    });
});

gulp.task('default', ['swagger']);
