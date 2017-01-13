angular
    .module('superheroesList')
    .component('superheroesList', {
        templateUrl: 'app/superheroes-list/superheroes-list.template.html',
        controller: function SuperheroListController ($rootScope, $scope, SuperheroService) {

            _setState();

            $rootScope.$on('event:hero-updated', function(){
                _setState();
            })

            function _setState(){
                $scope.$ctrl.superheroes = SuperheroService.getHeroes();
            }
        }
});