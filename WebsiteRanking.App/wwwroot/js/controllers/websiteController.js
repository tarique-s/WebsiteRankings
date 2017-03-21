'use strict';

websitesApp.controller('websitesController',
    function websitesController($scope, websitesDataService) {

        $scope.webistesVisitList = websitesDataService.webistesVisitList;
        $scope.visitDateList = websitesDataService.visitDateList;
    }
)