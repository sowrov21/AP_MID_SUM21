app.controller("DepartmentController", function ($scope, $http, ajax) {
	ajax.get("https://localhost:44353/api/Department/GetAll", success, error);
	function success(response) {
		$scope.departments = response.data;
	}
	function error(error) {}
});
