'use strict';

websitesApp.controller('websitesController',
    function websitesController($scope, websitesDataService) {

        websitesDataService.getVisitDates(function (visitDates) {
            $scope.visitDateList = visitDates;
        });

        websitesDataService.getWebsitesVisitList(function (websitesList) {
            $scope.webistesVisitList = websitesList;
        });
    }
)