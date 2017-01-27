(function(){

  angular.module('app',[]);

  angular.module('app')
        .controller('searchCtrl',['$scope','$http',function($scope,$http){

          $scope.searchString = "";
          $scope.searchResults = [];
var config = {headers:  {
        'Accept': 'application/json;odata=verbose',
    }
};

          $scope.getResults = function(){

                    if($scope.searchString==="")
                        {
                            $scope.searchResults=[];
                        }

else{
             $http.get("http://localhost:51115/api/Search?searchString="+$scope.searchString,config)
                 .then(function(response) {
                     $scope.searchResults = response.data;
    });
          }
}
        }]);


})();