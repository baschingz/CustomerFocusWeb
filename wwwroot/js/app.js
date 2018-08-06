var app = angular.module("myapp", []);
var url_string = document.URL;
var url = new URL(url_string);
var access_token = url.searchParams.get("access_token");
if (access_token != null) {
    localStorage.token = access_token;
}

