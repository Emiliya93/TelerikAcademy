function task4() {
    var divCount = numberOfElements('div');
    document.getElementById('divCountResult').innerHTML = 'Number of divs in this html page is: ' + divCount;
}

function numberOfElements(elementName) {
    return document.getElementsByTagName(elementName).length;
}