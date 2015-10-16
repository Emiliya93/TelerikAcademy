/*
 * Refactor the following examples to produce code with well-named identifiers in JavaScript
 */
/*globals window, alert*/
function checkIfBrowserIsMozilla(event, args) {
    'use strict';

    var myWindow = window,
        browser = myWindow.navigator.appCodeName,
        isMozilla = (browser === 'Mozilla');

    if (isMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}