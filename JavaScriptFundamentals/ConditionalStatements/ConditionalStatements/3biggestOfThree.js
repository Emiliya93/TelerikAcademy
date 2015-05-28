function biggestOfThree() {
    var firstNumber = document.getElementById('A3').value,
        secondNumber = document.getElementById('B3').value,
        thirdNumber = document.getElementById('C3').value,
        biggest;

    firstNumber = +firstNumber;
    secondNumber = +secondNumber;
    thirdNumber = +thirdNumber;
    debugger;
    if (firstNumber >= secondNumber && firstNumber >= thirdNumber) {

        document.getElementById('biggestResult').value = firstNumber;

    } else if (secondNumber >= firstNumber && secondNumber >= thirdNumber) {

        document.getElementById('biggestResult').value = secondNumber;

    } else if (thirdNumber >= firstNumber && thirdNumber >= secondNumber) {

        document.getElementById('biggestResult').value = thirdNumber;

    }

    //if (firstNumber >= secondNumber) {
    //    if (firstNumber >= thirdNumber) {
    //        biggest = firstNumber;
    //    } else {
    //        biggest = thirdNumber;
    //    }
    //} else if (secondNumber >= firstNumber) {
    //    if (secondNumber >= thirdNumber) {
    //        biggest = secondNumber;
    //    } else {
    //        biggest = thirdNumber;
    //    }
    //}
}