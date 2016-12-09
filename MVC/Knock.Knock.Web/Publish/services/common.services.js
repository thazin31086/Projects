(function () {
    "use strict";

    angular
        .module("common.services",
                    ["ngResource"])
    	.constant("appSettings",
        {
            serverPath: "http://localhost:52293https://knockknock.readify.net:443/"
        });
}());