/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 

*/
function solve() {
    return function (selector) {
        //debugger;
        if (typeof selector === 'undefined') {
            throw new Error('Selector cannot be undefined');
        }

        if (typeof selector === 'string') {
            selector = $(selector);
        }

        //if (!(selector instanceof jQuery)) {
        if (typeof selector.selector === 'undefined') {
            throw new Error('Selector must be DOM element');
        }

        if (selector.length === 0) {
            throw new Error('Selector does not select DOM element');
        }

        var $buttons = selector.children('.button'),
            $contents = selector.children('.content');

        if ($buttons.length === 0 || $contents.length === 0) {
            return;
        }

        $buttons.each(function (i, button) {
            button = $(button);
            button.text('hide');
        });

        selector.on('click', '.button', function () {
            var $this = $(this),
                currentSiblingElement = $this.next(),
                foundElement;

            while (currentSiblingElement.length) {
                if (currentSiblingElement.hasClass('button')) {
                    break;
                }

                if (currentSiblingElement.hasClass('content')) {
                    var next = currentSiblingElement.next();
                    while (next.length) {
                        if (next.hasClass('button')) {
                            foundElement = currentSiblingElement;
                            break;
                        }
                        next = next.next();
                    }
                }

                if (foundElement) {
                    break;
                }

                currentSiblingElement = currentSiblingElement.next();
            }

            if (foundElement) {
                if ($this.text().indexOf('hide') >= 0) {
                    $this.text('show');
                    foundElement.hide();
                } else {
                    $this.text('hide');
                    foundElement.css('display', '');
                }
            }
        });
    };
};

module.exports = solve;
//debugger;
//var s = solve();
//s('bls');