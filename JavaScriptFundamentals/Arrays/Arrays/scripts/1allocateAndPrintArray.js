function allocateAndPrintArray() {
    var i,
        len = 20,
        multiplier = 5,
        arrayOfInts = [];


    for (i = 0; i < len; i += 1) {
        arrayOfInts[i] = i * multiplier;
    }
    
    document.getElementById('arrayMembersResult').innerHTML = arrayOfInts.join(', ');
}