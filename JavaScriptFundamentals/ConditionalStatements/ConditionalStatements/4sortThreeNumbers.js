function sortThreeNumbers() {
    var a = document.getElementById('A4').value,
        b = document.getElementById('B4').value,
        c = document.getElementById('C4').value,
        sortedNums = '';

    a = +a;
    b = +b;
    c = +c;

    if (isNaN(a) || isNaN(b) || isNaN(c)) {
        document.getElementById('sortedResult').value = 'Invalid number/s!';
        return;
    }

    if (a >= b) {
        if (a >= c) {
            sortedNums += a + ' ';
            if (b >= c) {
                sortedNums += b + ' ' + c;
            } else {
                sortedNums += c + ' ' + b;
            }
        } else {
            sortedNums += c + ' ' + a + ' ' + b;
        }
    } else if (b >= c) {
        sortedNums += b + ' ';
        if (a >= c) {
            sortedNums += a + ' ' + c;
        } else {
            sortedNums += c + ' ' + a;
        }
    } else {
        sortedNums += c + ' ' + b + ' ' + a;
    }

    document.getElementById('sortedResult').value = sortedNums;
}