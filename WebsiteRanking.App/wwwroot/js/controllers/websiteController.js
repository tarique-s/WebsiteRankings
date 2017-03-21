'use strict';

websitesApp.controller('websitesController',
    function websitesController($scope) {
        $scope.helloMessage = 'Hello Tarique';

        $scope.webistesVisitList = [
            { "website": "www.google.com.au", "visitCount": 151749278 },
            { "website": "www.facebook.com", "visitCount": 104346720 },
            { "website": "www.youtube.com", "visitCount": 59811438 },
            { "website": "www.google.com", "visitCount": 26165099 },
            { "website": "ninemsn.com.au", "visitCount": 21734381 },
            { "website": "mail.live.com", "visitCount": 21536612 },
            { "website": "www.ebay.com.au", "visitCount": 19831166 },
            { "website": "www.bing.com", "visitCount": 14065457 },
            { "website": "www.wikipedia.org", "visitCount": 13246531 },
            { "website": "au.yahoo.com", "visitCount": 11492756 }]
    }
)