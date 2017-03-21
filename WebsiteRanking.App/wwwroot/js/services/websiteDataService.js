
websitesApp.factory('websitesDataService', function ($resource) {
    return {

        getVisitDates: function () {
            return $resource('https://wsrankingapi.azurewebsites.net/api/visitDates').query(); 
            //return $resource('http://localhost:8272/api/visitDates').query();

        },

        getWebsitesVisitList: function (selectedDate) {
            return $resource('https://wsrankingapi.azurewebsites.net/api/websites/:date/5').query({ date: selectedDate });  
            //return $resource('http://localhost:8272/api/websites/:date/5').query({ date: selectedDate });
            
        }
    };
});