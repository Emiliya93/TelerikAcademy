/* Task Description */
/* 
*   Create a function that replaces the content of an DOM element with divs with the provided contents
    *   Throws if:
        *   Any of the contents is not a string or a number
            *   Should not add any of the contents
        *   Any of the params is undefined or null
        *   The first parameter is neither string or HTMLElement
        *   The first parameter is an id (string) but there is not such element in the DOM
        *   The second parameter is not an array or an array-like object
*/

function solve() {
    var validator = {
            validateIfUndefined: function(val, name) {
                name = name || 'Value';

                if (typeof val === 'undefined') {
                    throw new Error(name + ' cannot be undefined!');
                }
            }
        };

    function clear(element) {
        while (element.firstChild) {
            element.removeChild(element.firstChild);
        }
    }

    /**
     * @param container - id of an element or selected element
     * @param contents - array of strings or/and numbers
     */
    return function (container, contents) {
        var hasArrayInvalidElement,
            divTemplate,
            fragment;


        validator.validateIfUndefined(container, 'Id or HTMLElement');

        validator.validateIfUndefined(contents, 'Array of contents');

        if (typeof container === 'string') {
            container = document.getElementById(container);
            //if (container === null) {
            //    throw new Error('There is no element that has such an id');
            //}
        }
        // check if need to be else if
        if (!(container instanceof HTMLElement)) {
            throw new Error('The function MUST take either an HTMLElement or id for existing element');
        }

        validator.validateIfUndefined(contents.length, 'Property length of contents');
 
        hasArrayInvalidElement = contents.some(function(content) {
            return (typeof content !== 'string' &&
                    typeof content !== 'number');
        });

        if (hasArrayInvalidElement) {
            throw new Error('Content MUST be a string or a number');
        }

        divTemplate = document.createElement('div'),
        fragment = document.createDocumentFragment();

        clear(container);

        contents.forEach(function (content) {
            divTemplate.innerHTML = content;
            fragment.appendChild(divTemplate.cloneNode(true));
        });

        container.appendChild(fragment);
    };
}

module.exports = solve;

//debugger;
//var result = solve();

////debugger;
//var fillWithDivs = solve();
//var contents = [],
//    count = 5,
//    i;
//    //contents = Array.call(Array, {
//    //    length: count
//    //})
//    //.map(function (_, index) {
//    //    return 'Content #' + index;
////});
//for (i = 0; i < count; i += 1) {
//    contents[i] = 'Content #' + i;
//}

//var root = document.getElementById('div');
//fillWithDivs(root, contents);
//var divs = root.getElementsByTagName('div');


//    var contents = [[], 1, 'String'],
//        selector = 'root',
//        root = document.getElementById(selector),
//        rootContent = '<h1>THis should remain</h1>';

//root.innerHTML = rootContent;

//function test() {
//    result(selector, contents);
//}
//test();

//var count = 15,
//    contents = Array
//        .apply(null, { length: count })
//        .map(function (_, index) {
//            return 'Content #' + index;
//        }),
//    selector = 'root';

//result(selector, contents);