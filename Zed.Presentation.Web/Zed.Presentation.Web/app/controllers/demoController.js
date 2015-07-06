(function() {
    'use strict';
    angular.module('Zed')
        .controller('DemoController', ['demoService', demoController]);

    function demoController() {
        var vm = this;
        vm.message = 'This is the demo page!';
        vm.isLoading = false;

        vm.getInfo = function(demoService) {
            vm.isLoading = true;
            var entry = vm.url;

            demoService.getResult(entry).then(console.log('DONE!'));
        };

    }
})();