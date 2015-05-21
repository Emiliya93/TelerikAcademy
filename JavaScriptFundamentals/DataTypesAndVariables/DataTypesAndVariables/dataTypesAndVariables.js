//Task 1

var intNum = 5,
    floatNum = 3.6,
    string = 'Some text',
    boolean = true,
    func = function () { console.log('This is my function.'); },
    array = [1, 2, 3, 4],
    myObject = { name: 'Smiley', age: 21 },
    nullValue = null,
    undefinedValue = undefined;

var allVariablesArray = [intNum, floatNum, string, boolean, func, array, myObject, nullValue, undefinedValue];
var allVariablesString = allVariablesArray.join('<br/>');

function showTask1() {
    document.getElementById("task1").innerHTML = 'Task 1: ' + '<br/>' + allVariablesString;
}

// Task 2

var quotedString = "`'How you doin'?', Joey said'.";

function showTask2() {
    var currentElement = document.getElementById("task2");
    currentElement.innerHTML = 'Task 2: ' + '<br/>' + quotedString;
}

// Task 3

function showTask3() {
    var i = 0,
        len = allVariablesArray.length,
        currentElement = document.getElementById('task3'),
        elementsAndTypes = "";

    for (i = 0; i < len; i += 1) {
        elementsAndTypes = elementsAndTypes + allVariablesArray[i] + ': ';
        elementsAndTypes = elementsAndTypes + (typeof allVariablesArray[i]);
        elementsAndTypes = elementsAndTypes + '<br/>';
    }

    currentElement.innerHTML = 'Task 3: ' + '<br/>' + elementsAndTypes;
}

// Task 4

var nullValue = null,
    undefinedValue = undefined;

function showTask4() {
    var currentElement = document.getElementById('task4');
    currentElement.innerHTML = 'Task 4: ' + '<br/>' + nullValue + ': ' + typeof (nullValue) + '<br/>' + undefinedValue + ': ' + typeof (undefinedValue);
}