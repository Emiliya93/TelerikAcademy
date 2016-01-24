function task2() {
    var input = document.getElementById('task2Input').value,
        result = document.getElementById('task2Result');

    if (correctBrackets(input)) {
        result.innerHTML = 'Correct expression.';
    } else {
        result.innerHTML = 'Incorrect expression.';
    }
}

function correctBrackets(input) {
    var i,
        len = input.length;
        brackets = 0;

        for (i = 0; i < len; i += 1) {
            if (input[i] === '(') {
                brackets += 1;
            } else if (input[i] === ')') {
                brackets -= 1;
            }
        }

        if (!brackets) {
            return true;
        }
        return false;
}