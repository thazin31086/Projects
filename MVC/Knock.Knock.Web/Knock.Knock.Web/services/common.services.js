﻿(function () {
    "use strict";

    angular
        .module("common.services",
                    ["ngResource"])
    	.constant("appSettings",
        {
            serverPath: "https://knockknock.readify.net:443/"
        });
}());