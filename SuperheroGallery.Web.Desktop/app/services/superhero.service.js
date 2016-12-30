(function () {
    'use strict';

    angular
        .module('superheroApp')
        .service('SuperheroService', SuperheroService);

    function SuperheroService($http) {

        return {
            getHeroes: _getHeroes,
            getHero: _getHero
        };

        // private

        function _handleResponse(res) {
            return res.data;
        }

        function _getHeroes() {
            return $http(
            {
                method: 'get',
                url: '/heroes'
            }).then(_handleResponse);
        }

        function _getHero(id) {
            return $http(
            {
                method: 'get',
                url: '/heroes/' + id
            }).then(_handleResponse);
        }
    }
})();