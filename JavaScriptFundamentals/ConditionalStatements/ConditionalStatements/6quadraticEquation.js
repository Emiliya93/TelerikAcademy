function quadraticEquation() {
    var x1,
        x2,
        d,
        sqrtD,
        a = document.getElementById('A6').value,
        b = document.getElementById('B6').value,
        c = document.getElementById('C6').value;
        
    a = +a;
    b = +b;
    c = +c;
    // TODO: Check with a=2,b=4,c=6 -> has to be no real roots!

    if (isNaN(a) || isNaN(b) || isNaN(c)) {
        document.getElementById('equationResult').value = 'Invalid number/s';
        return;
    }

    d = b * b - 4 * a * c;

    if (d > 0) {
        sqrtD = Math.sqrt(d);
        x1 = ((-b) + sqrtD) / (2 * a);
        x2 = ((-b) - sqrtD) / (2 * a);
    } else if (d < 0) {
        document.getElementById('equationResult').value = 'no real roots';
        return;
    } else {
        x1 = (-b) / (2 * a);
        x2 = x1;
    }

    document.getElementById('equationResult').value = 'x1 = ' + x1 + '; x2 = ' + x2;
}