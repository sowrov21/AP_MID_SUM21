var app = angular.module("myApp", ["ngRoute"]);
app.config([
	"$routeProvider",
	"$locationProvider",
	function ($routeProvider, $locationProvider) {
		$routeProvider
			.when("/", {
				templateUrl: "views/pages/home.html",
			})
			.when("/departments/details", {
				templateUrl: "views/pages/department.html",
				controller: "DepartmentController",
			})
			.when("/students/details", {
				templateUrl: "views/pages/student.html",
				controller: "StudentController",
			})
			.when("/about", {
				templateUrl: "views/pages/about.html",
			})
			.when("/admission/information", {
				templateUrl: "views/pages/admission.html",
			})
			.when("/project/details", {
				templateUrl: "views/pages/projects.html",
			})
			.when("/research/details", {
				templateUrl: "views/pages/research.html",
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
