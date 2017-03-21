'use strict';

websitesApp.controller('websitesController',
    function websitesController($scope, websitesDataService) {
        $scope.visitDateList = websitesDataService.getVisitDates();

        $scope.getWebsitesList = function (selectedDate) {
            if (selectedDate != '') {
                $scope.webistesVisitList = websitesDataService.getWebsitesVisitList(selectedDate);
            }
        }
    }
)