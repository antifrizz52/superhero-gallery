var superheroApp = angular.module('superheroApp', [
    'superheroesList',
    'superheroDetails',
    'superheroEdit',
    'superheroRating',
    'ngMaterial',
    'ui.router'
]);

superheroApp.config(function($stateProvider, $urlRouterProvider, $locationProvider) {
$locationProvider.html5Mode(true);

    var states = [
        {
            name: 'superheroApp',
            url: '/heroes',
            resolve: {
                superheroes: function(SuperheroService) {
                   SuperheroService.fetchHeroes();
                }
            },
            views: {
                "superheroesList": {
                    template: '<superheroes-list superheroes="$resolve.superheroes"></superheroes-list>'
                }
            }
        },
        {
            name: 'superheroDetails',
            parent: 'superheroApp',
            url: '/:id',
            resolve: {
                superhero: function ($stateParams, SuperheroService) {
                    SuperheroService.fetchHero($stateParams.id);
                }
            },
            views: {
                "superheroDetails@": {
                    template: '<superhero-details superhero="$resolve.superhero"></superhero-details>',
                }
            }
        }
    ];

    states.forEach(function(state) {
        $stateProvider.state(state);
    });
    
    $urlRouterProvider.otherwise('/heroes');
});