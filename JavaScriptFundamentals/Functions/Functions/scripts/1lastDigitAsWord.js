function task1() {
    var digit,
        digitAsWord = '',
        number = document.getElementById('number1').value;

    number = +number;

    digitAsWord = lastDigitAsWord(number);

    document.getElementById('lastDigitResult').innerHTML = digitAsWord;
}

function lastDigitAsWord(number) {
    var digitAsWord = '',
        digit = number % 10;
    switch (digit) {
        case 0: digitAsWord = 'zero'; break;
        case 1: digitAsWord = 'one'; break;
        case 2: digitAsWord = 'two'; break;
        case 3: digitAsWord = 'three'; break;
        case 4: digitAsWord = 'four'; break;
        case 5: digitAsWord = 'five'; break;
        case 6: digitAsWord = 'six'; break;
        case 7: digitAsWord = 'seven'; break;
        case 8: digitAsWord = 'eight'; break;
        case 9: digitAsWord = 'nine'; break;
        default: break;
    }

    return digitAsWord;
}