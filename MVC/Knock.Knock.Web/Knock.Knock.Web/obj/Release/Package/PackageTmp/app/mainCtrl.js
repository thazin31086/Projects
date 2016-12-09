(function () {
    "use strict";

    angular
        .module("knockknockproject")
        .controller("MainCtrl", [MainCtrl]);

    function MainCtrl() {
        var vm = this;       
        vm.errmessage = '';
        vm.fibonacci = '';
        vm.reversewords = '';        
        vm.triangletype_a = '';
        vm.triangletype_b = '';
        vm.triangletype_c = '';

        vm.fibonacciresult = '';
        vm.reversewordsresult = '';
        vm.tokensresult = '';
        vm.triangletyperesult = '';        

        vm.getFibonacci = function () {
            vm.fibonacciresult = "Result";           
        }

        vm.getReverse = function () {
            vm.reversewordsresult = "Result";
        }

        vm.getToken = function () {
            vm.tokensresult = "Result";
        }

        vm.gettriangletype = function () {
            vm.triangletyperesult = "Result";
        }
    }
})();
