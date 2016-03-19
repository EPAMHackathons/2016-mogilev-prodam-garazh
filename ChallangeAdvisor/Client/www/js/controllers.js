angular.module('starter.controllers', [])

.controller('AppCtrl', function ($scope, $ionicModal, $timeout) {

  // With the new view caching in Ionic, Controllers are only called
  // when they are recreated or on app start, instead of every page change.
  // To listen for when this page is active (for example, to refresh data),
  // listen for the $ionicView.enter event:
  //$scope.$on('$ionicView.enter', function(e) {
  //});

  // Form data for the login modal
  $scope.loginData = {};

  // Create the login modal that we will use later
  $ionicModal.fromTemplateUrl('templates/login.html', {
    scope: $scope
  }).then(function (modal) {
    $scope.modal = modal;
  });

  // Triggered in the login modal to close it
  $scope.closeLogin = function () {
    $scope.modal.hide();
  };

  // Open the login modal
  $scope.login = function () {
    $scope.modal.show();
  };

  // Perform the login action when the user submits the login form
  $scope.doLogin = function () {
    console.log('Doing login', $scope.loginData);

    // Simulate a login delay. Remove this and replace with your login
    // code if using a login system
    $timeout(function () {
      $scope.closeLogin();
    }, 1000);
  };
})

.controller('PlaylistsCtrl', function ($scope) {
  $scope.playlists = [
    { title: 'Reggae', id: 1 },
    { title: 'Chill', id: 2 },
    { title: 'Dubstep', id: 3 },
    { title: 'Indie', id: 4 },
    { title: 'Rap', id: 5 },
    { title: 'Cowbell', id: 6 }
  ];
})

.controller('PlaylistCtrl', function($scope, $stateParams) {
})

.controller('mainCtrl', function ($scope, $http) {
	var result = $http.get("http://localhost:49792/api/challenge/getchallenges").then(function (data) { console.log(data)})
	$scope.postList = [
		{
			Id:1,
			Title: "Aasdasd",
			Tags: ["hash1", "hash2", "hash3"],
			Author: "as",
			ImageLink : "https://aquaworld.com.mx/en/wp-content/uploads/sites/2/2015/12/diving-in-cancun-tour.jpg",
			Stories: [{Title: "abc", Id: "123"}]
		},
		{
			Id: 2,
			Title: "Aasdas",
			Tags: ["hash1", "hash2", "hash3"],
			Author: "as",
			ImageLink: "https://aquaworld.com.mx/en/wp-content/uploads/sites/2/2015/12/diving-in-cancun-tour.jpg",
			Stories: [{ Title: "abc", Id: "123" }]
		},
		{
			Id: 3,
			Title: "Aasdas",
			Tags: ["hash1", "hash2", "hash3"],
			Author: "as",
			ImageLink: "https://aquaworld.com.mx/en/wp-content/uploads/sites/2/2015/12/diving-in-cancun-tour.jpg",
			Stories: [{ Title: "abc", Id: "123" }]
		}, ];
})

.controller('SearchCtrl', function ($scope) {
  $scope.tags = [
    { title: 'Base jumping', id: 1 },
    { title: 'Extreme', id: 2 },
    { title: 'Bicycle', id: 3 },
    { title: 'Skydiving', id: 4 },
    { title: 'Paraplanerism', id: 5 },
  ];

  $scope.searchTypes = [
    { title: 'Search by Tags', id: 1 },
    { title: 'Search by Location', id: 2 }
  ];

  $scope.tags.search = function () { console.log("search") };
})

.controller('ChallengeCtrl', function ($scope, $stateParams) {
	console.log($stateParams.id);
})
;


