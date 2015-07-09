(function() {
    'use strict';
    angular.module('Zed')
        .controller('TemplateController', ['authService', '$scope', templateController]);

    function templateController(authService, $scope) {
        $scope.isLoggedIn = function () {
            if (authService.isLoggedIn()) {
                return false;
            } else {
                return true;
            }
        };
        $scope.isLoggedOut = function () {
            if (authService.isLoggedIn()) {
                return true;
            } else {
                return false;
            }
        }
    }
})();