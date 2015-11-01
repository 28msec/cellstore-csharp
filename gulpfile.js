'use strict';

var fs = require('fs');
var gulp = require('gulp');
var $ = require('gulp-load-plugins')();
var request = require('request');

gulp.task('swagger:clean', $.shell.task([
   'rm -rf build',
   'mkdir build'
]));

gulp.task('swagger:resolve', ['swagger:clean'], function(done){
    request({ url: 'http://28msec.github.io/cellstore-pro/swagger-aggregated.json' }, function(err, resp){
        fs.writeFileSync('build/swagger-aggregated.json', JSON.stringify(resp));
        done();
    });
});

gulp.task('swagger:install-codegen', ['swagger:resolve'], $.shell.task('cd build && curl -L -o swagger-codegen.zip https://github.com/28msec/swagger-codegen/archive/2149dc04d52811cbf89ac72ab17a57be6a6150ac.zip && unzip -q swagger-codegen.zip && cd swagger-codegen-2149dc04d52811cbf89ac72ab17a57be6a6150ac && mvn package && cp modules/swagger-codegen-cli/target/swagger-codegen-cli.jar .'));

gulp.task('swagger:generate-csharp', ['swagger:install-codegen'], $.shell.task([
    'cd build && java -jar swagger-codegen-cli.jar generate -i "swagger-aggregated.json" -l csharp  -o .'
]));

gulp.task('swagger:csharp', ['swagger:generate-csharp'], $.shell.task([
    'cd build && mcs -sdk:4.5 -r:bin/Newtonsoft.Json.dll,bin/RestSharp.dll,System.Runtime.Serialization.dll -target:library -out:bin/out-x86x64.dll -recurse:src/*.cs -doc:bin/out-x86x64.xml -platform:anycpu'
]));

gulp.task('default', ['swagger:csharp']);
