function task3() {
    var count = 0,
        input = document.getElementById('task3Input').value,
        subStringToCount = document.getElementById('task3Substring').value,
        result = document.getElementById('task3Result');

    count = countSubStringInText(input, subStringToCount);
    result.innerHTML = count;
}

function countSubStringInText(text, subString) {
    var i = 0,
        count = 0,
        len = subString.length;

    while ((i = text.indexOf(subString, i)) > -1) {
        count += 1;
        i = i + len;
    }

    return count;
}