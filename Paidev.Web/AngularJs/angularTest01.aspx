<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="angularTest01.aspx.cs" Inherits="Paidev.Web.AngularJs.angularTest01" %>

<!DOCTYPE html>
<html lang="ko" ng-app>
<head>    
    <title></title>    
    <style>
        .selected
        {
            background-color: lightgreen;
        }
    </style>
    <script src="/Js/angular.min.js"></script>
    <script>
        function RestaurantTableController($scope) {
            $scope.directory = [
                {
                    name: '소고기',
                    cuisine: '바베큐'
                },
                {
                    name: '샐러드',
                    cuisine: '샐러드',
                },
                {
                    name: '하우스',
                    cuisine: '해산물',
                }
            ];

            $scope.selectRestaurant = function (row) {
                $scope.selectedRow = row;
            };
        }
    </script>
</head>
<body>    
    <table ng-controller="RestaurantTableController">
        <tr ng-repeat="restaurant in directory" ng-click="selectRestaurant($index)" ng-class="{selected: $index == selectedRow}">
            <td>{{restaurant.name}}</td>
            <td>{{restaurant.cuisine}}</td>
        </tr>
    </table>
</body>
</html>
    