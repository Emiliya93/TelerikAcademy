function solve(){
    return function () {
        $.fn.listview = function (data) {
            var template = $('#' + this.attr('data-template')).html();
            template = '{{#each this}}' + template + '{{/each}}';

            var templateCompiler = handlebars.compile(template);
            var result = templateCompiler(data);

            this.append(result);

    };
  };
}

module.exports = solve;

 //solve()();
 //debugger;
 //var books = [{
 //    id: 1,
 //    title: 'JavaScript: The Good Parts'
 //}, {
 //    id: 2,
 //    title: 'Secrets of the JavaScript Ninja'
 //}, {
 //    id: 3,
 //    title: 'Core HTML5 Canvas'
 //}, {
 //    id: 4,
 //    title: 'JavaScript Patterns'
 //}];

 //$('#books-list').listview(books);