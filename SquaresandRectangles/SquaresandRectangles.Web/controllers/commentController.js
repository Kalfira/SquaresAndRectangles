(function () {
    'use strict';
    angular.module('Zed')
        .controller('CommentController', ['commentService', commentController]);

    function commentController(commentService) {
        var vm = this;
        vm.message = 'This is the comment page!';
        vm.isLoading = false;

        vm.getInfo = function () {
            vm.isLoading = true;
            var entry = angular.toJson(vm.perma);

            commentService.getResult(entry).then(function(result) {
                vm.title = result.UniversalItems[0];
                result.UniversalItems.shift();
                vm.result = result.UniversalItems;
                vm.isLoading = false;
                console.log("Done!");
            });
        };

    }
})();