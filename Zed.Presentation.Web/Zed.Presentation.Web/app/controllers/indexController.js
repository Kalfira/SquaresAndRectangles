﻿(function() {
    'use strict';
    angular.module('Zed')
        .controller('IndexController', indexController);

    function indexController() {
        var vm = this;
        vm.message = 'Index Controller!';
    }
})();