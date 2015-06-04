function numbersToN() {
    var i,
        result = [],
        count = document.getElementById('count1').value;

    count = +count;

    if (isNaN(count)) {
        document.getElementById('numbersToNResult').innerHTML = 'Invaid number!';
        return;
    }

    for (i = 0; i < count; i++) {
        result[i] = i + 1;
    }
    document.getElementById('numbersToNResult').innerHTML = result.join(', ');
    console.log(result.join(', '));
}