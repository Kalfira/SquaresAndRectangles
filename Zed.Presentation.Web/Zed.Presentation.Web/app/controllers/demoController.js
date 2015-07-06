(function() {
    'use strict';
    angular.module('Zed')
        .controller('DemoController', ['DemoService', demoController]);

    function demoController(demoService) {
        var vm = this;
        vm.message = 'This is the demo page!';
        vm.isLoading = false;

        vm.getInfo = function() {
            vm.isLoading = true;
            var entry = vm.url;

            demoService.getResult(entry).then(function() {
                vm.isLoading = false;
                console.log("Done!");
            });
        };

    }
})();