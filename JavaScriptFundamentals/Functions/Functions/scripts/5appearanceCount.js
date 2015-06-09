function task5() {
    var numbersStr = document.getElementById('numbers5').value,
        numbersArr = numbersStr.split(' '),
        searchedNum = document.getElementById('numberToSearch').value,
        count = 0;

    numbersArr.map(function (num) {
        if (num === searchedNum) {
            count += 1;
        }
    });

    document.getElementById('numberCountResult').innerHTML = 'Number ' + searchedNum + ' appears ' + count + ' time/s';
}