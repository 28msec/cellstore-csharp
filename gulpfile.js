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
    'cd build && java -jar swagger-codegen-cli.jar generate -i swagger-aggregated.json -l csharp  -o .'
]));

gulp.task('swagger:csharp', ['swagger:generate-csharp'], $.shell.task([
    'cd build && mcs -sdk:4.5 -r:bin/Newtonsoft.Json.dll,bin/RestSharp.dll,System.Runtime.Serialization.dll -target:library -out:bin/out-x86x64.dll -recurse:src/*.cs -doc:bin/out-x86x64.xml -platform:anycpu'
]));

gulp.task('swagger:pack', $.shell.task([
    'wget https://nuget.org/nuget.exe',
    'mono nuget.exe pack CellStore.dll.nuspec'
]));

gulp.task('swagger:push', $.shell.task([
    'mono nuget.exe setApiKey ' + process.env.NUGET_API_KEY + ' | cat &> /dev/null',
    'mono nuget.exe push CellStore.NET.' + version + '.nupkg'
]));

gulp.task('swagger', function(done){
    if(isOnTravisAndMaster) {
        $.runSequence('swagger:csharp', 'swagger:pack', 'swagger:push', done);
    } else {
        $.runSequence('swagger:csharp', done);
    }
});

gulp.task('default', ['swagger']);
