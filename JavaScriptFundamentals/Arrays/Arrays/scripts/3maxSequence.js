function maxSequence() {
    var i,
        j,
        len,
        maxNumber,
        currentCount = 0,
        maxCount = 0,
        currentNumber = 0,
        inSequence = false,
        sequenceArr = [],
        result = [],
        inputStr = document.getElementById('sequence3').value;

    sequenceArr = inputStr.split(', ');
    len = sequenceArr.length;

    for (i = 0; i < len; i+=1) {
        if ((i + 1) < len && sequenceArr[i] === sequenceArr[i + 1]) {
            inSequence = true;
        }

        if (inSequence) {
            currentNumber = +sequenceArr[i];

            for (j = i; j < len; j+=1) {
                if (sequenceArr[i] === sequenceArr[j]) {
                    inSequence = true;
                    currentCount += 1;
                } else {
                    i = j - 1;
                    inSequence = false;
                    break;
                }
            }
        }

        if (currentCount > maxCount) {
            maxCount = currentCount;
            maxNumber = currentNumber;
        }

        currentCount = 0;
        currentNumber = 0;
    }

    for (i = 0; i < maxCount; i+=1) {
        result[i] = maxNumber;
    }

    document.getElementById('maxSequenceResult').innerHTML = result.join(', ');
}