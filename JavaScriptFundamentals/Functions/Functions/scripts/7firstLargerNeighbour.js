function largerThanNeighbours(position, arrOfInts) {
    var len = arrOfInts.length;

    if ((position - 1) >= 0 && (position + 1) < len) {
        if ((arrOfInts[position] > arrOfInts[position - 1]) && (arrOfInts[position] > arrOfInts[position + 1])) {
            return position;
        }
    }
    return -1;
}

function task7() {
    var i,
        len,
        index = -1,
        arr = document.getElementById('arr7').value,
        result = document.getElementById('firstLargerResult');

    arr = arr.split(' ');
    arr = arr.map(Number);
    len = arr.length;

    for (i = 0; i < len; i += 1) {
        index = largerThanNeighbours(i, arr);
        if (index > -1) {
            break;
        }
    }

    result.innerHTML = index;
}