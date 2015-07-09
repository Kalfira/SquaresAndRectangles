(function() {
    'use strict';
    angular.module('Zed')
        .controller('LogoutController', ['authService', logoutController]);

    function logoutController(authService) {
        var vm = this;
        vm.message = "This is the logout page!";
        authService.logout();
    }

})();