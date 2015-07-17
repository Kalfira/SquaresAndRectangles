(function() {
    'use strict';
    angular.module('Zed')
        .controller('LoginController', ['authService', '$location', loginController])

    function loginController(authService, $location) {
        var vm = this;
        
        function loginSuccess() {
            $location.path('/');
        }
        function loginFail() {
            console.log("Login Failed!");
        }
        vm.login = function () {
            authService.login(vm.username, vm.password).then(loginSuccess, loginFail);
        }
        vm.redditLogin = function () {
            var x = angular.toJson([vm.reddituser, vm.redditpass]);
            //var postData = "'" + 'api_type=json&user=' + vm.reddituser + '&passwd=' + vm.redditpass + "'";
            authService.redditLogin(x).then(loginSuccess, loginFail);;
        }
    }
})();