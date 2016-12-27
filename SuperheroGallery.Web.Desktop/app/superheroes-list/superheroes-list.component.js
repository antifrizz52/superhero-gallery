angular
    .module('superheroesList')
    .component('superheroesList', {
        bindings: {superheroes: '<'},
        templateUrl: 'app/superheroes-list/superheroes-list.template.html'
});