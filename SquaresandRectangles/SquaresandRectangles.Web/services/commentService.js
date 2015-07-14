﻿(function () {
    'use strict';
    angular.module('Zed')
        .factory('CommentService', commentService);

    function commentService($http, $q) {
        var service = {};
        var deferred = $q.defer();

        service.getResult = getResult;

        function getResult(perma) {
            var deferred = $q.defer();
            $http({
                url: 'http://localhost:1337/api/Comment/' + perma,
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