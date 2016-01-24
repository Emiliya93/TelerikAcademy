/* globals $ */

/* 

Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:   
  * The UL must have a class `items-list`
  * Each of the LIs must:
    * have a class `list-item`
    * content "List item #INDEX"
      * The indices are zero-based
  * If the provided selector does not selects anything, do nothing
  * Throws if
    * COUNT is a `Number`, but is less than 1
    * COUNT is **missing**, or **not convertible** to `Number`
      * _Example:_
        * Valid COUNT values:
          * 1, 2, 3, '1', '4', '1123'
        * Invalid COUNT values:
          * '123px' 'John', {}, [] 
*/

function solve() {
    var validator = {
        validateIfUndefined: function (val, name) {
            name = name || 'Value';

            if (typeof val === 'undefined') {
                throw new Error(name + ' cannot be undefined!');
            }
        }
    };

    return function (selector, count) {
        var root = $(selector),
            fragment = document.createDocumentFragment(),
            ul = $('<ul />').addClass('items-list'),
            i;

        validator.validateIfUndefined(selector, 'Selector');
        validator.validateIfUndefined(count, 'Count');

        //count = parseFloat(count);
        count = +count;
        if (isNaN(count) || count < 1) {
            throw new Error('COUNT is **not convertible** to `Number` or is less than 1');
        }

        if (typeof selector !== 'string') {
            throw new Error('Selector is not a string!');
        }

        if (root.length === 0) {
            return;
        }

        for (i = 0; i < count; i += 1) {
            var li = $('<li />')
                .addClass('list-item')
                .text('List item #' + i)
                .appendTo(ul);
        }

        ul.appendTo(root);
  };
};

module.exports = solve;

//var count = 5,
//    result = solve();
//document.body.innerHTML = '<div id="root"></div>';
//debugger;
//result('#root', count);