(function() {
    'use strict';
    angular.module('Zed')
        .factory('DemoService', demoService);

    function demoService($http, $q) {
        var service = {};
        var deferred = $q.defer();

        service.getResult = getResult;

        function getResult(url) {
            var deferred = $q.defer();
            $http({
                url: '/api/url',
                method: 'POST',
                data: url
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

        return service;
    }
})();