function solve() {
    return function sum(arr) {
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
}