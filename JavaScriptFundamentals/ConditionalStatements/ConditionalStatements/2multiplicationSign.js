function multiplicationSign() {
    var firstNumber = document.getElementById('A2').value,
        secondNumber = document.getElementById('B2').value,
        thirdNumber = document.getElementById('C2').value,
        minusCounter = 0;

    firstNumber = +firstNumber;
    secondNumber = +secondNumber;
    thirdNumber = +thirdNumber;

    if (isNaN(firstNumber) || isNaN(secondNumber) || isNaN(thirdNumber)) {
        document.getElementById('signResult').value = 'Invalid number/s!';
        return;
    }
    if (!firstNumber || !secondNumber || !thirdNumber) {
        document.getElementById('signResult').value = '0';
    } else {
        if (firstNumber < 0) {
            minusCounter += 1;
        }
        if (secondNumber < 0) {
            minusCounter += 1;
        }
        if (thirdNumber < 0) {
            minusCounter += 1;
        }

        if (minusCounter % 2) {
            // odd number of minuses => negative result
            document.getElementById('signResult').value = '-';
        } else {
            // positive result
            document.getElementById('signResult').value = '+';
        }
    }
}