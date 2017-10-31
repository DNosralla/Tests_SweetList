var app = angular.module("app", ["ngRoute"]);

app.config(function ($routeProvider) {
    $routeProvider
        .when("/", {
            templateUrl: "/app/main.html",
            controller: "mainCtrl"
        });
});

app.controller('mainCtrl', function ($scope, $http, $q, $route) {
    var self = this;

    $scope.name = '';
    $scope.countryId = '';

    self.getCountries = $http.get('/api/country');
    self.getCustomers = $http.get('/api/customer');

    self.load = function () {
        $scope.loading = true;

        return $q.all([
            self.getCountries,
            self.getCustomers
        ]).then(function (values) {
            $scope.countryList = values[0].data;
            $scope.customerList = values[1].data;

            $scope.loading = false;
        });
    }
    
    
    $scope.newCustomer = function () {
        
        if ($scope.saving) {
            return;
        }

        $scope.saving = true;

        $http.post('/api/customer/', {
            name: $scope.name,
            countryId: $scope.countryId
        }).
            then(
            function (okResponse) {
                console.log('ok');

                $scope.name = '';
                $scope.countryId = '';

                $scope.saving = false;
                $route.reload();
            },
            function (error) {
                $scope.saving = false;
                $scope.modelState = error.data.modelState;
            });

    }

    self.load();
});