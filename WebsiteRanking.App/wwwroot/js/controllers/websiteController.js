'use strict';

websitesApp.controller('websitesController',
    function websitesController($scope, websitesDataService) {

        $scope.visitDateList = websitesDataService.getVisitDates();

        $scope.webistesVisitList = websitesDataService.getWebsitesVisitList('2016-01-13');
    }
)