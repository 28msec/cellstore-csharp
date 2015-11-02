'use strict';

var fs = require('fs');
var gulp = require('gulp');
var $ = require('gulp-load-plugins')();
var request = require('request');

var isOnTravis = process.env.CIRCLECI === 'true';
var isOnTravisAndMaster = isOnTravis && process.env.CI_PULL_REQUEST === '' && process.env.CIRCLE_BRANCH === 'master';

var version = '0.0.3';

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

gulp.task('swagger:pack', function(done){
    $.nugetPack({
        id: 'CellStore.NET',
        version: version,
        authors: '28msec',
        owners: 'dknochen',
        licenseUrl: 'https://raw.githubusercontent.com/28msec/cellstore-csharp/master/LICENSE',
        projectUrl: 'https://github.com/28msec/cellstore-csharp',
        iconUrl: 'http://www.28.io/images/favicon/32x32.png',
        requireLicenseAcceptance: false,
        description: 'A CSharp Library for interfacing with the 28msec\'s Cell Store API',
        copyright: 'Copyright 2015 28msec',
        tags: 'CellStore JSONiq',
        dependencies: [
            { id: 'RestSharp', version: '(105.2.3, )' },
            { id: 'Newtonsoft.Json', version: '(7.0.1, )' }
        ]
    }, [
        { src: 'build/bin/CellStore.dll', dest: 'lib/CellStore.dll' },
        { src: 'build/bin/CellStore.xml', dest: 'doc/CellStore.xml' }
    ], done);
});

gulp.task('swagger:push', $.shell.task([
    'wget https://nuget.org/nuget.exe',
    'mono nuget.exe setApiKey ' + process.env.NUGET_API_KEY + ' &> /dev/null',
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
