/* globals $, Handlebars*/

function solve() {
    return function (selector) {
        debugger;
        var templateHTML =
          '<table class="items-table">' +
              '<thead>' +
                  '<tr>' +
                      '<th>#</th>' +
                      '{{#each headers}}' +
                      '<th>{{this}}</th>' +
                      '{{/each}}' +
                  '</tr>' +
              '</thead>' +
              '<tbody>' +
                  '{{#each items}}' +
                      '<tr>' +
                          '<td>{{@index}}</td>' +
                          '<td>{{col1}}</td>' +
                          '<td>{{col2}}</td>' +
                          '<td>{{col3}}</td>' +
                      '</tr>' +
                  '{{/each}}' +
              '</tbody>' +
          '</table>'
            ,
            data = {
                headers: ['Vendor', 'Model', 'OS'],
                items: [{
                    col1: 'Nokia',
                    col2: 'Lumia 920',
                    col3: 'Windows Phone'
                }, {
                    col1: 'LG',
                    col2: 'Nexus 5',
                    col3: 'Android'
                }, {
                    col1: 'Apple',
                    col2: 'iPhone 6',
                    col3: 'iOS'
                }]
            };
          //template = Handlebars.compile(templateHTML),
          //result = template(data);

     $(selector).html(templateHTML);
  };
};

module.exports = solve;