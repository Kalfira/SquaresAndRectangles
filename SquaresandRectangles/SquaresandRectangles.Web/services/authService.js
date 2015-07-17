(function () {
    'use strict';
    angular.module('Zed')
        .factory('authService', authService);

    function authService($http, $q, $window) {
        var service = {};

        service.login = login;
        service.logout = logout;
        service.isLoggedIn = isLoggedIn;
        service.redditLogin = redditLogin;
        service.thirdParty = null;
        service.getThirdParty = getThirdParty;

        function login(username, password) {
            var deferred = $q.defer();

            $http({
                url: 'http://localhost:1337/Token',
                method: 'POST',
                data: 'username=' + username + '&password=' + password + '&grant_type=password',
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            }).success(function (data) {
                $window.sessionStorage.setItem('token', data.access_token);
                deferred.resolve();
            }).error(function (err) {
                console.log(err);
                deferred.reject();
            });
            return deferred.promise;
        }

        function logout() {
            $window.sessionStorage.removeItem('token');
            service.thirdParty = null;
        }

        function isLoggedIn() {
            var loggedIn = $window.sessionStorage.getItem('token');
            if (loggedIn) {
                return true;
            } else {
                return false;
            }
        }

        function redditLogin(postData) {
            var deferred = $q.defer();
            $http({
                url: 'http://localhost:1337/r/login',
                method: 'POST',
                data: postData,
            }).success(function (data) {
                //$window.sessionStorage.setItem('redditToken', data);
                if (service.thirdParty === null) {
                    service.thirdParty = [data];
                } else {
                    service.thirdParty.push(data);
                }
                console.log(data);
                deferred.resolve();
            }).error(function (err) {
                console.log(err);
                deferred.reject();
            });
            return deferred.promise;
        }
        function getThirdParty(callback) {
            callback(service.thirdParty);
        }
        return service;
    }

})();