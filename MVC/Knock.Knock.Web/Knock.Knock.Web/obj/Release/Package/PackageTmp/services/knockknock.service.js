(function () {
    "use strict";

    angular
        .module("common.services")
        .factory("knockknock.service",
                ["$resource",
                 "appSettings",              
                  knockknock])

    function knockknock($resource, appSettings) {
        return{
                Fibonacci: $resource(appSettings.serverPath + "/api/Account/Register/:n", null,
                    {  
                         'GetFibonacci': { method: 'GET' }
                    }),

                ReverseWords: $resource(appSettings.serverPath + "/api/Account/Register/:sentence", null,
                    {
                        'GetReverseWords': { method: 'GET' }
                    }),

                Token: $resource(appSettings.serverPath + "/api/Account/Register/", null,
                    {
                        'GetToken': { method: 'GET' }
                    }),

                TriangleType: $resource(appSettings.serverPath + "/api/Account/TriangleType/:a/:b/:c", null,
                    {
                        'GetTriangleType': { method: 'GET' }
                    })
            }
    }
}());

