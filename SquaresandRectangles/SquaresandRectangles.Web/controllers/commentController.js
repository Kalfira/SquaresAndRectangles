(function () {
    'use strict';
    angular.module('Zed')
        .controller('CommentController', ['commentService', GetComments]);

    function GetComments(commentService) {
        var vm = this;
        vm.message = 'This is the comment page!';
        vm.isLoading = false;

        vm.getInfo = function () {
            vm.isLoading = true;
            var entry = vm.perma;

            commentService.getResult(entry).then(function (result) {
                vm.message = result;
                vm.isLoading = false;
                console.log("Done!");
            });
        };

    }
})();