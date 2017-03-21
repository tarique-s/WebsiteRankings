
websitesApp.factory('websitesDataService', function ($resource) {
    return {

        getVisitDates: function () {
            return $resource(backEndApi + 'visitDates').query(); 

        },

        getWebsitesVisitList: function (selectedDate) {
            return $resource(backEndApi + 'websites/:date/5').query({ date: selectedDate });  
            
        }
    };
});

// $resource('http://localhost:8272/api/visitDates').query();
 //return $resource('http://localhost:8272/api/websites/:date/5').query({ date: selectedDate });