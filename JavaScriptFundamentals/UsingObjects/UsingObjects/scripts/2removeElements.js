﻿var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];

console.log('Task 2:');
console.log('Old array: ');
console.log(arr);

Array.prototype.remove = function (value) {
    while (this.indexOf(value) >= 0) {
        this.splice(this.indexOf(value), 1);
    }
    return this;
};

arr.remove(1);
console.log('Array after removing number 1:');
console.log(arr);
console.log('----------------------------------------------------');