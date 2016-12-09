(function () {
    "use strict";

    angular
        .module("knockknockproject")
        .controller("MainCtrl", ["knockknockservice", MainCtrl]);

    function MainCtrl(knockknockservice) {
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
            knockknockservice.Fibonacci.GetFibonacci({ n: vm.fibonacci },
            function (data) {
                vm.fibonacciresult = "Result: " + data;
            },
            function (response) {
                vm.errmessage = response.statusText + "\r\n";
                if (response.data.exceptionMessage)
                    vm.errmessage += response.data.exceptionMessage;
            });
        }

        vm.getReverse = function () {
            knockknockservice.ReverseWords.GetReverseWords({ sentence: vm.reversewords },
            function (data) {
                vm.reversewordsresult = "Result: " + data;
            },
            function (response) {
                vm.errmessage = response.statusText + "\r\n";
                if (response.data.exceptionMessage)
                    vm.errmessage += response.data.exceptionMessage;
            });
        }

        vm.getToken = function () {
            knockknockservice.Token.GetToken(null,
            function (data) {
                vm.tokensresult = "Result: " + data;
            },
            function (response) {
                vm.errmessage = response.statusText + "\r\n";
                if (response.data.exceptionMessage)
                    vm.errmessage += response.data.exceptionMessage;
            });
        }

        vm.gettriangletype = function () {

            knockknockservice.TriangleType.GetTriangleType({ a: vm.triangletype_a, b: vm.triangletype_b, c: vm.triangletype_c },
            function (data) {
                vm.triangletyperesult = "Result: " + data;
            },
            function (response) {
                vm.errmessage = response.statusText + "\r\n";
                if (response.data.exceptionMessage)
                    vm.errmessage += response.data.exceptionMessage;
            });
        }
    }
})();
