angular
    .module('superheroRating')
    .component('superheroRating', {
        bindings: {superhero: '<', isReadonly: '<'},
        templateUrl: 'app/superhero-rating/superhero-rating.template.html',
        controller: function SuperheroRatingController($rootScope) {
            
            var vm = this;

            vm.rating = 0;

            this.$onInit = function() {
                _setState();
            };

            this.$onChanges = function(changes){
                _setState();
            }

            vm.setRating = function(rating) {
                if(!vm.isReadonly) {
                    vm.superhero.Rating = rating;
                    _setState();
                }
            }

            function _setState() {
                vm.rating = vm.superhero.Rating;
            }
        }
});  