(function() {
'use strict';

    angular
        .module('superheroApp')
        .service('SuperheroService', SuperheroService);

    function SuperheroService() {

         var superheroes = [
            {
                id: 0,
                name: 'Superman',
                rating: 5,
                description: "Superman bla bla bla",
                logoUrl: "app/heroes/superman-logo.png"
            },
            {   
                id: 1,
                name: "Batman",
                rating: 4,
                description: "Batman bla bla bla",
                logoUrl: "app/heroes/batman-logo.png"
            },
            {   
                id: 2,
                name: "Spiderman",
                rating: 3,
                description: "Spiderman bla bla bla",
                logoUrl: "app/heroes/spiderman-logo.png"
            },
            {
                id: 3,
                name: "Hulk",
                rating: 5,
                description: "Hulk bla bla bla",
                logoUrl: "app/heroes/hulk-logo.png"
            },
            {
                id: 4,
                name: "Ironman",
                rating: 5,
                description: "Ironman bla bla bla",
                logoUrl: "app/heroes/ironman-logo.png"
            }
        ];

        return {
            getHeroes: _getHeroes
        };

        // private

        function _getHeroes() {
            return superheroes;
        }
    }
})();