(function() {
    'use strict';
    angular.module('Zed')
        .factory('DemoService', demoService);

    function demoService($http, $q) {
        var service = {};
        var deferred = $q.defer();

        service.getInfo = getInfo;

        function getInfo(url) {
            var deferred = $q.defer();
            $http({
                url: '/api/url',
                method: 'GET',
                data: URL,
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