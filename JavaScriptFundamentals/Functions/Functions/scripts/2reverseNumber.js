function task2() {
    var result,
        number = document.getElementById('number2').value;
   
    result = reverseNumber(number);

    document.getElementById('reversedNumber').innerHTML = result;
}

function reverseNumber(number) {
    var reversed = 0;

    while (number) {
        reversed *= 10;
        reversed += number % 10;

        number /= 10;
        number = number | 0;
    }

    return reversed;
}