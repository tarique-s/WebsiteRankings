
websitesApp.factory('websitesDataService', function ($http, $log) {
    return {

        getVisitDates: function (successCb) {
            //$http({ method: 'GET', url: 'http://websiterankingapi.azurewebsites.net/api/visitDates' }).
            $http({ method: 'GET', url: 'http://localhost:8272/api/visitDates' }).
            success(function (data, status, headers, config){
                successCb(data);
            }).
            error(function (data, status, headers, config) {
                $log.warn(data, status, headers, config);
            })
        },

        getWebsitesVisitList: function (successCb) {
            //$http({ method: 'GET', url: 'http://websiterankingapi.azurewebsites.net/api/websites/2016-01-06/5' }).
            $http({ method: 'GET', url: 'http://localhost:8272/api/websites/2016-01-06/5' }).
            success(function (data, status, headers, config) {
                    successCb(data);
            }).
            error(function (data, status, headers, config) {
                    $log.warn(data, status, headers, config);
            })
        }
    };
});