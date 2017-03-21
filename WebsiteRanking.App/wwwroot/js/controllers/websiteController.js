'use strict';

websitesApp.controller('websitesController',
    function websitesController($scope, websitesDataService) {
        $scope.visitDateList = websitesDataService.getVisitDates();
        //$scope.selectedDate = $scope.visitDateList[0];

        //$scope.webistesVisitList = websitesDataService.getWebsitesVisitList('2016-01-13');

        $scope.getWebsitesList = function (selectedDate) {
            if (selectedDate != '') {
                $scope.webistesVisitList = websitesDataService.getWebsitesVisitList(selectedDate);
            }
        }
    }
)