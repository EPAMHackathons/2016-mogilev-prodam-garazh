angular.module('starter.controllers', [])
.controller('mainCtrl',['$scope', function($scope) {
    $scope.postList = function(){
        return [{Title:"A"},{Title:"B"}]
    }
}]);
