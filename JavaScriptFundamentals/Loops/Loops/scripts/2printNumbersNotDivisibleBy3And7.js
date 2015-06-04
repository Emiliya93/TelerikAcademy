function printNumbersNotDivisible() {
    var i,
        j,
        result = [],
        count = document.getElementById('count2').value;

    count = +count;

    if (isNaN(count)) {
        document.getElementById('notDivisibleResult').innerHTML = 'Invaid number!';
        return;
    }

    for (i = 1, j = 0; i <= count; i++) {
        if ((i % 3 !== 0) && (i % 7 !== 0)) {
            result[j] = i;
            j += 1;
        }
    }
    document.getElementById('notDivisibleResult').innerHTML = result.join(', ');
}