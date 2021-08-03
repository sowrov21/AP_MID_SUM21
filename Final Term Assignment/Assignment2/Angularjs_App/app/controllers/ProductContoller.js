app.controller("ProductContoller",function($scope,$http,ajax,$location,$routeParams){
    ajax.get(API_ROOT+"api/Product/GetAll",success,error);
    function success(response){
      $scope.products=response.data;
    }
    function error(error){

    }

    ajax.get(API_ROOT+"api/Category/GetAll",
    
    function (response){
      $scope.categories=response.data;
    },
    function (error){

    }
    );

   // Add New Product
    $scope.addproduct = function(){
      //$scope.selectedOption=0;

      ajax.post(API_ROOT+"api/Product/Add",$scope.p,
        
        function (response){
          $location.path("/products");
        },
        function (error){

        });

    }

      // Show Product Details
      var id= $routeParams.id;
      ajax.get(API_ROOT+"api/Product/"+id+"/Details",
        
      function (response){
        $scope.product=response.data;
      },
      function (error){
  
      }
      );


     // Delete Product api/Product/{id}/Delete

     var id= $routeParams.id;
     ajax.get(API_ROOT+"api/Product/"+id+"/Delete",
       
     function (response){
       $scope.product=response.data;
     },
     function (error){
 
     }
     );



  
});

app.controller("EditProduct",function($scope,$http,ajax,$location,$routeParams){

    
  var id= $routeParams.id;
  ajax.get(API_ROOT+"api/Product/"+id+"/Details",
    
  function (response){
    $scope.product=response.data;
  },
  function (error){

  }
  );
  
  ajax.get(API_ROOT+"api/Category/GetAll",
  
  function (response){
    $scope.categories=response.data;
  },
  function (error){

  }
  );


   // Edit Product
   $scope.updateproduct = function (){

    ajax.post(API_ROOT+"api/Product/Edit",$scope.product,
      
    function (response){
      $location.path("/products");
    },
    function (error){

    });

   }


});

