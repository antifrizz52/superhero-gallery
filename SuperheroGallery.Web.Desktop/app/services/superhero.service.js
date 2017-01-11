(function () {
    'use strict';

    angular
        .module('superheroApp')
        .service('SuperheroService', SuperheroService);

    function SuperheroService($http, $rootScope) {

        var heroes = [];

        return {
            getHeroes: _getHeroes,
            getHero: _getHero,
            saveHero: _saveHero,
            heroes: heroes,
            fetchHero: _fetchHero,
            fetchHeroes: _fetchHeroes
        };

        // private

        function _handleResponse(res) {
            return res.data;
        }

        function _fetchHeroes() {
            return $http.get('/heroes')
                .then(_handleResponse)
                .then(function(res) { 
                    heroes = res; 
                });
        }

        function _getHeroes() {
            return angular.copy(heroes);
        }

        function _fetchHero(id) {
            return $http.get('/heroes/' + id)
                .then(_handleResponse);
                // .then(_updateHero);
        }

        function _getHero(id) {
            for (var hero in heroes) {
                if (heroes[hero].Id == id) {
                    return angular.copy(heroes[hero]);
                }
            }
        }

        function _saveHero(superhero) {
            return $http.post('/heroes', superhero)
                .then(_handleResponse)
                .then(_updateHero);
        }

        function _updateHero(updatedHero) {
            for (var hero in heroes) {
                if (heroes[hero].Id == updatedHero.Id) {
                    heroes[hero] = updatedHero;
                    break;
                }
            }

            $rootScope.$emit('event:hero-updated');
        }
    }
})();