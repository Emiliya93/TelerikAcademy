function minAndMax() {
    var i,
        len,
        min,
        max,
        inputNumArr,
        firstLoop = true,
        inputStr = document.getElementById('inputMinMax').value;
    debugger;
    inputNumArr = inputStr.split(' ');

    for (i = 0, len = inputNumArr.length; i < len; i+=1) {
        inputNumArr[i] = +inputNumArr[i];

        if (inputNumArr[i] == '') {
            continue;
        } else if (isNaN(inputNumArr[i])) {
            document.getElementById('minMaxResult').innerHTML = 'Invalid number/s!';
        }

        if (firstLoop) {
            min = inputNumArr[i];
            max = inputNumArr[i];

            firstLoop = false;
        }

        if (inputNumArr[i] > max) {
            max = inputNumArr[i];
        }

        if (inputNumArr[i] < min) {
            min = inputNumArr[i];
        }
    }

    document.getElementById('minMaxResult').innerHTML = 'Min: ' + min + '; Max: ' + max;
}