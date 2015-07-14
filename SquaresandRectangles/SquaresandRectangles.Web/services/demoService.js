(function() {
    'use strict';
    angular.module('Zed')
        .factory('DemoService', demoService);

    function demoService($http, $q) {
        var service = {};
        var deferred = $q.defer();

        service.getResult = getResult;
        service.getZed = getZed;

        function getResult(url) {
            var deferred = $q.defer();
            $http({
                url: 'http://localhost:1337/r/'+url,
                method: 'GET'
            }).success(function(data) {
                if (data) {
                    deferred.resolve(data);
                }
            }).
            error(function(data) {
                console.log('Demo failed!');
                deferred.reject(data);
            });

            return deferred.promise;
        }

        function getZed() {
            var deferred = $q.defer();
            $http({
                url: 'http://localhost:1337/z',
                method: 'GET'
            }).success(function (data) {
                if (data) {
                    deferred.resolve(data);
                }
            }).
            error(function (data) {
                console.log('Demo failed!');
                deferred.reject(data);
            });

            return deferred.promise;
        }


        return service;
    }
})();