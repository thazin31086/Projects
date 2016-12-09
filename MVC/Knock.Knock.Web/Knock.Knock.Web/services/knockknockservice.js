(function () {
    "use strict";

    angular
        .module("common.services")
        .factory("knockknockservice",
                ["$resource",
                 "appSettings",
                  knockknock])

    function knockknock($resource, appSettings) {
        return {
            Fibonacci: $resource(appSettings.serverPath + "/api/Fibonacci/:n", null,
                    {
                        'GetFibonacci': { method: 'GET' }
                    }),

            ReverseWords: $resource(appSettings.serverPath + "/api/ReverseWords/:sentence", null,
                    {
                        'GetReverseWords': { method: 'GET' }
                    }),

            Token: $resource(appSettings.serverPath + "/api/Token", null,
                    {
                        'GetToken': { method: 'GET' }
                    }),

            TriangleType: $resource(appSettings.serverPath + "/api/TriangleType/:a/:b/:c", null,
                    {
                        'GetTriangleType': { method: 'GET' }
                    })
        }
    }
}());

