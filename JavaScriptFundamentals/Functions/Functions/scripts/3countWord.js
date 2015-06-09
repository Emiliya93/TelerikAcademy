function task3(isSenditive) {
    isSenditive = isSenditive || false;
    var wordCount,
        text = document.getElementById('text3').value,
        word = document.getElementById('word3').value;

    wordCount = countWordCaseInsensitive(text, word, isSenditive);
    document.getElementById('wordsCountResult').innerHTML = wordCount;
}

function countWordCaseInsensitive(text, word, isSensitive) {
    var i,
        len,
        newText = text.replace(/\W+/g, ' '),
        words = newText.split(' '),
        count = 0;

    if (isSensitive) {
        for (var i = 0, len = words.length; i < len; i++) {
            if (words[i] === word) {
                count += 1;
            }
        }
    } else {
        word = word.toLowerCase();

        for (var i = 0, len = words.length; i < len; i++) {
            if (words[i].toLowerCase() === word) {
                count += 1;
            }
        }
    }
    return count;
}