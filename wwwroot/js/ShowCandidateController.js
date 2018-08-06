
app.controller("ShowCandidateController", function ($scope, $http) {
    $scope.employees = typeof employees != "undefined" ? employees ? employees : null : null;
    $scope.init = function () {
        //debugger;
        $http.defaults.headers.common.Authorization = 'Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJjaGluZ2NoYW5hQGdtYWlsLmNvbSIsImVtYWlsIjoiY2hpbmdjaGFuYUBnbWFpbC5jb20iLCJ0eXAiOiJjb21tdW5pdHkiLCJhY3IiOiJSZWNydWl0bWVudCIsImp0aSI6ImYyZmI2NmNiLTJmN2ItNDM3Ni1hYWE5LTIxZjY0MTNjNDNhNCIsImV4cCI6MTUzMzU1MzEzMiwiaXNzIjoiaHR0cDovL2xvY2FsaG9zdDo0NDMwOC8iLCJhdWQiOiJodHRwOi8vbG9jYWxob3N0OjQ0MzA4LyJ9.NP0v7ib0zC0srarf5rI1c-1BLz7-2avmW_MRlgithTE';
        $http.get("http://localhost:44308/api/generateuser").then(function (response) {

            if (response.data) {
                //debugger;
                alert('ดึงรายชื่อสำเร็จ');
                $scope.employees = response.data;
            } else {
                alert('ดึงรายชื่อไม่สำเร็จ');
            }
        }, function (response) {
            //debugger;
            alert('fail');
        });
    }
});