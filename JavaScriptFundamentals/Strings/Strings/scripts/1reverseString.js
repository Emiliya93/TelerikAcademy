function task1() {
    var resultStr = '',
        input = document.getElementById('task1Input').value,
        result = document.getElementById('task1Result');

    resultStr = reverseString(input);
    result.innerHTML = resultStr;
}

function reverseString(input) {
    var i,
        len = input.length,
        reversed = '';
    for (i = len - 1; i >= 0; i -= 1) {
        reversed += input[i];
    }
    return reversed;
}