function exchangeIfGreater() {
    var firstNumber = document.getElementById('A1').value,
        secondNumber = document.getElementById('B1').value;

    if (firstNumber > secondNumber) {
        document.getElementById('exchangeResult').value = secondNumber + ' ' + firstNumber;
    } else {
        document.getElementById('exchangeResult').value = firstNumber + ' ' + secondNumber;
    }
}