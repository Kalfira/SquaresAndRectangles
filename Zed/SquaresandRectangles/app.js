(function() {
    'use strict';
    angular.module('Zed', ['ngRoute']).config(Config);

    function Config($routeProvider) {
        $routeProvider.when('/', {
                templateUrl: '/app/views/index.html',
                controller: 'IndexController',
                controllerAs: 'vm'
            }).when('/demo', {
                templateUrl: '/app/views/demo.html',
                controller: 'DemoController',
                controllerAs: 'vm'
            }).when('/login', {
                templateUrl: '/app/views/login.html',
                controller: 'LoginController',
                controllerAs: 'vm'
            }).when('/logout', {
                templateUrl: '/app/views/index.html',
                controller: 'LogoutController',
                redirectTo: '/'
            }).otherwise({
                redirectTo: '/'
            });
    }

    Config.$inject = ['$routeProvider'];

})();