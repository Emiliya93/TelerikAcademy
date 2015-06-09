function task6() {
    var arr = document.getElementById('arrOfInts').value,
        position = document.getElementById('position').value,
        result = document.getElementById('largerResult');

    arr = arr.split(' ');
    arr = arr.map(Number);
    position = +position;
    
    result.innerHTML = largerThanNeighbours(position, arr);
    
}

function largerThanNeighbours(position, arrOfInts) {
    var len = arrOfInts.length;
    if (position < 0 || position > len) {
        return ('Position is out of the bounds of the array!');
    }
    else if ((position - 1) >= 0 && (position + 1) < len) {
        if ((arrOfInts[position] > arrOfInts[position - 1]) && (arrOfInts[position] > arrOfInts[position + 1])) {
            return ('Number at position ' + position +
                ' is larger than it\'s two neighbours (' +
                arrOfInts[position - 1] + ' < ' + arrOfInts[position] +
                ' > ' + arrOfInts[position + 1] + ')');
        }
    } else {
        return ('Number at position ' + position + ' has no two neighbours!');
    }
}