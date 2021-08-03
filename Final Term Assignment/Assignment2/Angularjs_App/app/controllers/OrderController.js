app.controller("GetAllOrder", function ($scope, $http, ajax, $location) {
	ajax.get(API_ROOT + "api/Order/GetAll", success, error);
	function success(response) {
		
		$scope.orders = response.data;
		

	}
	function error(error) {}
});

app.controller(
	"GetOrderDetails",
	function ($scope, $http, ajax, $location, $routeParams) {
		var id = $routeParams.id;
		ajax.get(
			API_ROOT + "api/Order/Get/" + id + "/WithProductDetails",
			success,
			error
		);
		function success(response) {
			$scope.order = response.data;

			$scope.total = 0;
			$scope.order.OrderDetails.forEach((product) => {
				$scope.total += product.ProductPrice * product.Quantity;
				
			});
			$scope.total = $scope.total + 50;
		}
		function error(error) {}
	}
);
