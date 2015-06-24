/* Task description */
/*
	Write a function a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `string`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(start, end) {
    var num,
        sqrtNum,
        isPrime,
        result = [];

    start = +start;
    end = +end;
    if (isNaN(start) || isNaN(end)) {
        throw new Error('Any of the range params is not convertible to Number!');
    }

    for (num = start; num <= end; num += 1) {
        sqrtNum = Math.sqrt(num);
        isPrime = true;

        if (num < 2) {
            continue;
        }

        for (var i = 2; isPrime && i <= sqrtNum; i += 1) {
            if (!(num % i)) {
                isPrime = false;
            }
        }

        if (isPrime) {
            result.push(num);
        }
    }

    return result;
}

module.exports = findPrimes;