function deepCopy(obj) {
    if (typeof obj !== 'object') {
        return obj;
    }

    var cloned = {};
    for (var prop in obj) {
        cloned[prop] = deepCopy(obj[prop]);
    }

    return cloned;
}

console.log('Task 3:');
console.log(deepCopy(3));
console.log(deepCopy({ name: 'Smiley', age: 21 }));
console.log('----------------------------------------------------');