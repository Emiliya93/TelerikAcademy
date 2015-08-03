/* globals $ */

/* 

Create a function that takes an id or DOM element and:
  

*/

function solve(){
    return function (selector) {
        if (typeof selector === 'undefined') {
            throw new Error('Selector cannot be undefined');
        }

        if (typeof selector === 'string') {
            selector = document.getElementById(selector);
        }

        if (!(selector instanceof HTMLElement)) {
            throw new Error('Selector must be DOM element');
        }

        var buttons = selector.getElementsByClassName('button'),
            contents = selector.getElementsByClassName('content'),
            i,
            len = buttons.length;

        //console.log(buttons);
        //buttons.forEach(function (button) {
        //    button.innerHTML = 'hide';
        //});
        //for (i = 0; i < len; i += 1) {
        //    buttons[i].innerHTML = 'hide';
        //}
        Array.prototype.forEach.call(buttons, function (button) {
            button.innerHTML = 'hide';
        });

        selector.addEventListener('click', function (ev) {
            var clickedElement = ev.target,
                currentSiblingElement = clickedElement.nextElementSibling,
                foundElement;

            // select content
            while (currentSiblingElement) {
                if (currentSiblingElement.className === 'button') {
                    break;
                }

                if (currentSiblingElement.className === 'content') {
                    if (currentSiblingElement.nextElementSibling &&
                        currentSiblingElement.nextElementSibling.className === 'button') {
                        foundElement = currentSiblingElement;
                        break;
                    }
                }

                currentSiblingElement = currentSiblingElement.nextElementSibling;
            }

            // hide or show content
            if (foundElement) {
                //console.log('found element');
                //console.log(foundElement);
                //console.log('->' + window.getComputedStyle(foundElement).display + '<=');

                var currentVisibility = window.getComputedStyle(foundElement).display;

                //if (currentVisibility == 'block') {
                if (currentVisibility != 'none') {
                    foundElement.style.display = 'none';
                    clickedElement.innerHTML = 'show';

                } else if (currentVisibility == 'none') {
                    foundElement.style.display = '';
                    clickedElement.innerHTML = 'hide';
                }
            }
        }, false);
  };
};

module.exports = solve;