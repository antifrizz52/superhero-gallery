angular
    .module('superheroDetails', ['ngMaterial'])
    .component('superheroDetails', {
        bindings: {superhero: '<'},
        templateUrl: 'app/superhero-details/superhero-details.template.html',
        controller: function SuperheroDetailsController($scope, $mdDialog) {
            this.showEditForm = function($event) {

                var heroCopy = angular.copy($scope.$parent.$resolve.superhero);

                var confirm = 
                $mdDialog.show({
                    controller: DialogController,
                    templateUrl: 'app/superhero-edit/superhero-edit.template.html',
                    targetEvent: $event,
                    clickOutsideToClose: true,
                    locals: {superhero: heroCopy}
                });

                confirm
                    .then(function(result){
                    angular.extend($scope.$parent.$resolve.superhero, result);
                }).catch(function(){
                });
            };

            function DialogController($scope, $mdDialog, superhero) {
                $scope.superhero = superhero;

                $scope.hide = function() {
                    $mdDialog.hide();
                };

                $scope.cancel = function() {
                    $mdDialog.cancel();
                };

                $scope.save = function() {
                    $mdDialog.hide(superhero);
                };
            };
        }
});
