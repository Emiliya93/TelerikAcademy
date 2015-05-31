function biggestOfFive() {
    var a = document.getElementById('A7').value,
        b = document.getElementById('B7').value,
        c = document.getElementById('C7').value,
        d = document.getElementById('D7').value,
        e = document.getElementById('E7').value,
        biggest;

    a = +a;
    b = +b;
    c = +c;
    d = +d;
    e = +e;

    biggest = a;

    if (b >= biggest) {
        biggest = b;
    }
    if (c >= biggest) {
        biggest = c;
    }
    if (d >= biggest) {
        biggest = d;
    }
    if (e >= biggest) {
        biggest = e;
    }

    document.getElementById('biggestOfFiveResult').value = biggest;
}