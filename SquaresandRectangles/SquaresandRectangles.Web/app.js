(function() {
    'use strict';
    angular.module('Zed', ['ngRoute']).config(Config);

    function Config($routeProvider) {
        $routeProvider.when('/', {
                templateUrl: './views/index.html',
                controller: 'IndexController',
                controllerAs: 'vm'
            }).when('/demo', {
                templateUrl: './views/demo.html',
                controller: 'DemoController',
                controllerAs: 'vm'
            }).when('/login', {
                templateUrl: './views/login.html',
                controller: 'LoginController',
                controllerAs: 'vm'
            }).when('/z', {
            templateUrl: './views/zed.html',
            controller: 'ZedController',
            controllerAs: 'vm'
            }).when('/logout', {
                templateUrl: './views/index.html',
                controller: 'LogoutController',
                redirectTo: '/'
            }).when('/comment', {
                templateUrl: './views/comments.html',
                controller: 'commentController',
                controllerAs: 'vm'
            }).otherwise({
                redirectTo: '/'
            });
    }

    Config.$inject = ['$routeProvider'];
})();