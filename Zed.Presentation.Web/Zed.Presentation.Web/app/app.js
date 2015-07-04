(function() {
    'use strict';
    angular.module('Zed', ['ngRoute']).config(Config);

    function Config($routeProvider) {
        $routeProvider.when('/', {
            templateUrl: '/app/views/index.html',
            controller: 'IndexController',
            controllerAs: 'vm'
        }).otherwise({
            redirectTo: '/'
        });
    }

    Config.$inject = ['$routeProvider'];

})();