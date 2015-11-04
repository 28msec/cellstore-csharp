'use strict';

var fs = require('fs');
var gulp = require('gulp');
var $ = require('gulp-load-plugins')();
var request = require('request');
var parseString = require('xml2js').parseString;

var isOnTravis = process.env.CIRCLECI === 'true';
var isOnTravisAndMaster = isOnTravis && process.env.CI_PULL_REQUEST === '' && process.env.CIRCLE_BRANCH === 'master';
var version;

parseString(fs.readFileSync('CellStore.dll.nuspec', 'utf-8'), { async: false }, function (err, result) {
    version = result.package.metadata[0].version[0];
});

gulp.task('swagger:clean', $.shell.task([
   'rm -rf build',
   'mkdir build'
]));

gulp.task('swagger:resolve', ['swagger:clean'], function(done){
    request({ url: 'http://28msec.github.io/cellstore-pro/swagger-aggregated.json' }, function(err, resp){
        fs.writeFileSync('build/swagger-aggregated.json', resp.body);
        done();
    });
});

gulp.task('swagger:install-codegen', ['swagger:resolve'], $.shell.task('cd build && curl -L -o swagger-codegen.zip https://github.com/28msec/swagger-codegen/archive/2149dc04d52811cbf89ac72ab17a57be6a6150ac.zip && unzip -q swagger-codegen.zip && cd swagger-codegen-2149dc04d52811cbf89ac72ab17a57be6a6150ac && mvn package && cp modules/swagger-codegen-cli/target/swagger-codegen-cli.jar ..'));

gulp.task('swagger:generate-csharp', ['swagger:install-codegen'], $.shell.task([
    'cp codegen-options.json build',
    'cd build && java -jar swagger-codegen-cli.jar generate -i swagger-aggregated.json -l csharp -c codegen-options.json  -o .'
]));

gulp.task('swagger:csharp', ['swagger:generate-csharp'], $.shell.task([
    'cd build && mcs -sdk:4.5 -r:bin/Newtonsoft.Json.dll,bin/RestSharp.dll,System.Runtime.Serialization.dll -target:library -out:bin/CellStore.dll -recurse:src/*.cs -doc:bin/CellStore.xml -platform:anycpu'
]));

gulp.task('swagger:test', $.shell.task([
    'mcs -sdk:4.5 -r:build/bin/Newtonsoft.Json.dll,build/bin/RestSharp.dll,build/bin/CellStore.dll,System.Runtime.Serialization.dll samples/GetFacts/GetFacts/Program.cs',
    'mono samples/GetFacts/GetFacts/Program.exe'
]));

gulp.task('swagger:pack', $.shell.task([
    'cp CellStore.dll.nuspec build',
    'cd build && wget https://nuget.org/nuget.exe',
    'cd build && mono nuget.exe pack CellStore.dll.nuspec'
]));

gulp.task('swagger:push', $.shell.task([
    'cd build && mono nuget.exe setApiKey ' + process.env.NUGET_API_KEY + ' | cat &> /dev/null',
    'cd build && mono nuget.exe push CellStore.NET.' + version + '.nupkg'
]));

gulp.task('swagger', function(done){
    if(isOnTravisAndMaster) {
        $.runSequence('swagger:csharp', 'swagger:test', 'swagger:pack', 'swagger:push', done);
    } else {
        $.runSequence('swagger:csharp', 'swagger:test', done);
    }
});

gulp.task('default', ['swagger']);
