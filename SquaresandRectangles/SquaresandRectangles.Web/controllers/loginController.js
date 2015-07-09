(function() {
    'use strict';
    angular.module('Zed')
        .controller('LoginController', ['authService', '$location', loginController])

    function loginController(authService, $location) {
        var vm = this;
        vm.login = function () {
            authService.login(vm.username, vm.password).then(loginSuccess, loginFail);
        }
        function loginSuccess() {
            $location.path('/');
        }
        function loginFail() {
            console.log("Login Failed!");
        }
    }
})();