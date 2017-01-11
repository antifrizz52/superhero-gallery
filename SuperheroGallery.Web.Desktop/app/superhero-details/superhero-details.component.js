angular
    .module('superheroDetails', ['ngMaterial'])
    .component('superheroDetails', {
        //bindings: {superhero: '<'},
        templateUrl: 'app/superhero-details/superhero-details.template.html',
        controller: function SuperheroDetailsController($rootScope, $state, $scope, $mdDialog, SuperheroService) {

            _setState();

            this.showEditForm = function($event) {
                var heroCopy = angular.copy($scope.$ctrl.superhero);

                $mdDialog.show({
                    controller: DialogController,
                    templateUrl: 'app/superhero-edit/superhero-edit.template.html',
                    targetEvent: $event,
                    clickOutsideToClose: true,
                    locals: {superhero: heroCopy}
                });
            };

            $rootScope.$on('event:hero-updated', function(){
                _setState();
            })

            function DialogController($scope, $mdDialog, superhero) {
                $scope.superhero = superhero;

                $scope.hide = function() {
                    $mdDialog.hide();
                };

                $scope.cancel = function() {
                    $mdDialog.cancel();
                };

                $scope.save = function() {
                    SuperheroService.saveHero(superhero);
                    $mdDialog.hide();
                };
            };

            function _setState(){
                $scope.$ctrl.superhero = SuperheroService.getHero($state.params.id);
            }
        }
});
