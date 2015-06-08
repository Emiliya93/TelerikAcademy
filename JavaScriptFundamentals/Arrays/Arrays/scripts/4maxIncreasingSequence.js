function maxIncreasingSequence() {
    var i,
        j,
        len,
        inSequence = false,
        currentCount = 1,
        maxCount = 1,
        firstNumber = 0,
        maxNumber = 0,
        sequenceArr = [],
        result = [],
        inputStr = document.getElementById('sequence4').value;

    sequenceArr = inputStr.split(', ');
    len = sequenceArr.length;

    for (i = 0; i < len; i += 1) {
        sequenceArr[i] = +sequenceArr[i];

        if ((i + 1) < len) {
            sequenceArr[i + 1] = +sequenceArr[i + 1];

            if (sequenceArr[i] === (sequenceArr[i + 1] - 1)) {
                inSequence = true;
            }
        }

        if (inSequence) {
            firstNumber = sequenceArr[i];

            for (j = i; j < len; j += 1) {
                sequenceArr[j] = +sequenceArr[j];

                if (j + 1 < len) {
                    sequenceArr[j + 1] = +sequenceArr[j + 1];

                    if (sequenceArr[j] === (sequenceArr[j + 1] - 1)) {
                        inSequence = true;
                        currentCount += 1;
                    } else {
                        i = j - 1;
                        inSequence = false;
                        break;
                    }
                }
            }
        }

        if (currentCount > maxCount) {
            maxCount = currentCount;
            maxNumber = firstNumber;
        }

        currentCount = 1;
        firstNumber = 0;
    }

    for (i = 0; i < maxCount; i+=1) {
        result[i] = maxNumber + i;
    }

    document.getElementById('maxIncreasingSequence').innerHTML = result.join(', ');
}