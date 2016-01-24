/* globals $ */

function solve() {
  
    return function (selector) {
        if (typeof selector === 'undefined') {
            throw new Error('Selector can not be undefined!');
        }

      var template = 
        '<div class="container">' +
            '<h1>Animals</h1>' +
            '<ul class="animals-list">' +
                '{{#each animals}}' +
                '<li>' +
                    '{{#if this.url}}' +
                        '<a href="{{this.url}}">' +
                            'See a {{this.name}}' +
                        '</a>' +
                        '{{else}}' +
                        '<a href="http://cdn.playbuzz.com/cdn/3170bee8-985c-47bc-bbb5-2bcb41e85fe9/d8aa4750-deef-44ac-83a1-f2b5e6ee029a.jpg">' +
                            'No link for {{this.name}} , here is Batman!' +
                        '</a>' +
                    '{{/if}}' +
                    
                '</li>' +
                '{{/each}}' +
            '</ul>' +
        '</div>'
      ;
      var data = {
          animals: [{
              name: 'Lion',
              url: "https://susanmcmovies.files.wordpress.com/2014/12/the-lion-king-wallpaper-the-lion-king-2-simbas-pride-4685023-1024-768.jpg"
          }, {
              name: 'Turtle',
              url: 'http://www.enkivillage.com/s/upload/images/a231e4349b9e3f28c740d802d4565eaf.jpg'
          }, {
              name: 'Dog'
          }, {
              name: 'Cat',
              url: 'http://i.imgur.com/Ruuef.jpg'
          }, {
              name: 'Dog Again'
          }]
      };
      //var templateCompiler = handlebars.compile(template),
      //    result = templateCompiler(data);
      //document.getElementById(selector).innerHTML = result;
    $(selector).html(template);   
  };
};

module.exports = solve;
