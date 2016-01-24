function countClicks() {
    var btn = document.getElementById('btn'),
        count = btn.value;

    console.log(count);

    btn.value = ++count;

    console.log(btn.value);
}