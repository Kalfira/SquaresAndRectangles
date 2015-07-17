(function() {
    'use strict';
    angular.module('Zed')
        .controller('TemplateController', ['authService', '$scope', templateController]);

    function templateController(authService, $scope) {
        var vm = this;
        function thirdParty(result) {
            vm.third = result;
        }
        $scope.isLoggedIn = function () {
            if (authService.isLoggedIn()) {
                return false;
            } else {
                return true;
            }
        };
        $scope.isLoggedOut = function() {
            if (authService.isLoggedIn()) {
                return true;
            } else {
                return false;
            }
        }
        $scope.hasThirdParty = function() {
            if (authService.thirdParty) {
                return false;
            } else {
                return true;
            }
        }
        $scope.thirdParty = function () { return authService.thirdParty; }

    }
})();