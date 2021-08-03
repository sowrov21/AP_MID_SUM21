var app = angular.module("myApp", ["ngRoute"]);
var API_ROOT = "https://localhost:44317/";
app.config([
	"$routeProvider",
	"$locationProvider",
	function ($routeProvider, $locationProvider) {
		$routeProvider
			.when("/", {
				templateUrl: "views/pages/dashboard.html",
			})
			.when("/products", {
				templateUrl: "views/pages/products.html",
				controller: "ProductContoller",
			})
			.when("/addproduct", {
				templateUrl: "views/pages/addproduct.html",
				controller: "ProductContoller",
			})
			.when("/productdetails/:id", {
				templateUrl: "views/pages/productdetails.html",
				controller: "ProductContoller",
			})
			.when("/productedit/:id", {
				templateUrl: "views/pages/editproduct.html",
				controller: "EditProduct",
			})
			.when("/productdelete/:id", {
				templateUrl: "views/pages/products.html",
				controller: "DeleteProduct",
			})
			.when("/categories", {
				templateUrl: "views/pages/categories.html",
				controller: "CategoryController",
			})
			.when("/addcategory", {
				templateUrl: "views/pages/addcategory.html",
				controller: "CategoryController",
			})
			.when("/categoryedit/:id", {
				templateUrl: "views/pages/editcategory.html",
				controller: "EditCategory",
			})
			.when("/orders", {
				templateUrl: "views/pages/orders.html",
				controller: "GetAllOrder",
			})
			.when("/addorder", {
				templateUrl: "views/pages/addorder.html",
				controller: "AddOrders",
			})
			.when("/orderdetail/:id", {
				templateUrl: "views/pages/orderdetails.html",
				controller: "GetOrderDetails",
			})
			.otherwise({
				redirectTo: "/",
			});
		//$locationProvider.html5Mode(true);
		//$locationProvider.hashPrefix('');
		//if(window.history && window.history.pushState){
		//$locationProvider.html5Mode(true);
		//}
	},
]);
