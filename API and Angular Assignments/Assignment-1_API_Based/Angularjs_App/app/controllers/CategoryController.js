app.controller("CategoryController",function($scope,$http,ajax,$location){
    ajax.get(API_ROOT+"api/Category/GetAll",success,error);
    function success(response){
      $scope.categories=response.data;
    }
    function error(error){

    }

    $scope.addcategory = function()
    {
      var ctgObj = {
        Id: 0,
        Name: $scope.Name
      };
      ajax.post(API_ROOT+"api/Category/Add",ctgObj,
      function (response){
        $location.path("/categories");
      },
      function (error){
  
      }
      );
    }
});
