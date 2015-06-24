function solve() {
	return function findPrimes(start, end) {
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
}