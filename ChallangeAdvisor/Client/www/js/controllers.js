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
	$http({
		method: 'GET',
		url: '/api/challenge/getchallenges',
		withCredentials: false,
		headers: {
			'Content-Type': 'application/json; charset=utf-8',
			'Access-Control-Allow-Origin': '*'
		}
	}).then(function (data) { console.log(data) })

	$scope.postList = [
		{
			Id:1,
			Title: "Post title",
			Tags: ["hash1", "hash2", "hash3"],
			Author: "John Doe",
			AvatarLink : 'https://upload.wikimedia.org/wikipedia/commons/d/d3/User_Circle.png',
			ImageLink: "https://www.disruptsurfing.com/wp-content/uploads/2016/01/Surf-1.jpg",
			Stories: [{Title: "abc", Id: "123"}]
		},
		{
			Id: 2,
			Title: "Title",
			Tags: ["hash1", "hash2", "hash3"],
			Author: "User Name",
			AvatarLink: 'https://upload.wikimedia.org/wikipedia/commons/d/d3/User_Circle.png',
			ImageLink: "http://www.xtremespots.com/wp-content/uploads/2013/07/BASE-Jumping-at-Navagio-Beach1.jpg",
			Stories: [{ Title: "abc", Id: "123" }]
		},
		{
			Id: 3,
			Title: "Challenge name",
			Tags: ["hash1", "hash2", "hash3"],
			Author: "Chuck Norris",
			AvatarLink: 'https://upload.wikimedia.org/wikipedia/commons/d/d3/User_Circle.png',
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

.controller('MapCtrl', function ($scope, $state) {
  var options = { timeout: 10000, enableHighAccuracy: true };

  function pos() {

    var latLng = new google.maps.LatLng(55.7558260, 37.6173000);

    var mapOptions = {
      center: latLng,
      zoom: 15,
      mapTypeId: google.maps.MapTypeId.ROADMAP
    };

    $scope.map = new google.maps.Map(document.getElementById("map"), mapOptions);

  };
  pos();
});


