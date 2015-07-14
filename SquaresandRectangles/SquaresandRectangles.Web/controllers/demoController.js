(function () {
    'use strict';
    angular.module('Zed')
        .controller('DemoController', ['DemoService', demoController]);

    function demoController(demoService) {
        var vm = this;
        vm.message = 'This is the demo page!';
        vm.isLoading = false;
        vm.tableHidden = true;

        vm.getInfo = function () {
            vm.isLoading = true;
            var infoEntry = vm.subreddit;

            demoService.getResult(infoEntry).then(function (result) {
                vm.info = angular.fromJson(result);
                console.log(vm.info);
                vm.tableHidden = false;
                vm.isLoading = false;
                console.log("Done!");
            });
        }
        vm.getZed = function () {
            vm.isLoading = true;
            var zedEntry = vm.zed;

            demoService.getZed(zedEntry).then(function (result) {
                
                vm.message = result;
                vm.isLoading = false;
                console.log("Done!");
            });
        }
    }
})();