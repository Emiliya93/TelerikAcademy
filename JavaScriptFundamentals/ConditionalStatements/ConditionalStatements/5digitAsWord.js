function digitAsWord() {
    var digit = document.getElementById('digit').value;
    digit = +digit;

    switch (digit) {
        case 0: document.getElementById('digitWordResult').value = 'zero'; break;
        case 1: document.getElementById('digitWordResult').value = 'one'; break;
        case 2: document.getElementById('digitWordResult').value = 'two'; break;
        case 3: document.getElementById('digitWordResult').value = 'three'; break;
        case 4: document.getElementById('digitWordResult').value = 'four'; break;
        case 5: document.getElementById('digitWordResult').value = 'five'; break;
        case 6: document.getElementById('digitWordResult').value = 'six'; break;
        case 7: document.getElementById('digitWordResult').value = 'seven'; break;
        case 8: document.getElementById('digitWordResult').value = 'eight'; break;
        case 9: document.getElementById('digitWordResult').value = 'nine'; break;
        default: document.getElementById('digitWordResult').value = 'not a digit'; break;
    }
}