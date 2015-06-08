function lexicographicallyComparison() {
    var i,
        minLen,
        len1,
        len2,
        result = '',
        firstString = document.getElementById('firstCharArr').value,
        secondString = document.getElementById('secondCharArr').value;

    len1 = firstString.length;
    len2 = secondString.length;

    for (i = 0, minLen = Math.min(len1, len2) ; i < minLen; i += 1) {
        if (firstString[i] < secondString[i]) {
            result = 'Lexicographically compared: ' + '</br>' + firstString + '</br>' + secondString;
            break;
        } else if (firstString[i] > secondString[i]) {
            result = 'Lexicographically compared: ' + '</br>' + secondString + '</br>' + firstString;
            break;
        }
    }

    if (result === '') {
        if ((firstString.length < secondString.length)) {
            result = 'Lexicographically compared: ' + '</br>' + firstString + '</br>' + secondString;
        } else if (secondString.length < firstString.length) {
            result = 'Lexicographically compared: ' + '</br>' + secondString + '</br>' + firstString;
        }
    }

    document.getElementById('comparisonResult').innerHTML = result;
}