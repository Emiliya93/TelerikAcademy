/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum(arr) {
    var len,
    i,
    sum = 0;

    if (arr === undefined) {
        throw new Error('No arguments passed to the function!');
    }

    len = arr.length;

    if (!len) {
        return null;
    }
    arr = arr.map(function (num) {
        num = +num;
        if (isNaN(num)) {
            throw new Error('Any of the elements is not convertible to Number!');
        }
        return num;
    });

    for (i = 0; i < len; i += 1) {
        sum += arr[i];
    }

    return sum;
}

module.exports = sum;