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


    //Category Details api/Category/{id}/Details

   /* var id= $routeParams.id;
    ajax.get(API_ROOT+"api/Category/"+id+"/Details",
      
    function (response){
      $scope.category=response.data;
    },
    function (error){

    }
    );*/
});

app.controller("EditCategory",function($scope,$http,ajax,$location,$routeParams){

    
  var id= $routeParams.id;
  ajax.get(API_ROOT+"api/Category/"+id+"/Details",
    
  function (response){
    $scope.category=response.data;
  },
  function (error){

  }
  );
  


   // Edit Product
   $scope.editcategory = function (){

    ajax.post(API_ROOT+"api/Category/Edit",$scope.category,
      
    function (response){
      $location.path("/categories");
    },
    function (error){

    });

   }

});


