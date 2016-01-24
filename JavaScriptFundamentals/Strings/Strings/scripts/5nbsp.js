function task5() {
    var text = document.getElementById('task5Input').value,
        result = document.getElementById('task5Result');
    
    result.innerHTML = 'Result is in the console';
    console.log(replaceWithNbsp(text));
}

function replaceWithNbsp(text) {
    var i,
        len = text.length,
        result = [];

    for (i = 0; i < len; i += 1) {
        if (text[i] === ' ') {
            result.push('&nbsp');
        } else {
            result.push(text[i]);
        }
    }
    return result.join('');
}