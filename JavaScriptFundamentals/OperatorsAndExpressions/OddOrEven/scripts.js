// Problem 1. Odd or Even

function oddOrEven() {
    var input = document.getElementById('oddOrEvenInput').value;

    //Convert input to number
    input = +input;

    if (isNaN(input)) {
        document.getElementById('oddOrEvenInput').value = 'Invalid number!';
    } else if (input % 2) {
        // Number is Odd
        document.getElementById('oddOrEvenInput').value = 'True';
    } else {
        // Number is Even
        document.getElementById('oddOrEvenInput').value = 'False';
    }
}

// Problem 2. Divisible by 7 and 5

function divisibleBy5And7() {
    var input = document.getElementById('divisibleInput').value;

    if (isNaN(input)) {
        document.getElementById('divisibleInput').value = 'Invalid number!';
    } else if (!(input % 35)) {
        document.getElementById('divisibleInput').value = 'True';
    } else {
        document.getElementById('divisibleInput').value = 'False';
    }
}

// Problem 3. Rectangle area

function rectangleArea() {
    var width = document.getElementById('rectangleWidth').value,
        height = document.getElementById('rectangleHeight').value,
        area = width * height;

    document.getElementById('rectangleArea').value = 'Area is: ' + area;
}

//Problem 4. Third digit

function isThirdDigitSeven() {
    var number = document.getElementById('thirdDigitInput').value,
        digit,
        i = 0,
        isSeven = false;

    for (i = 0; i < 3; i += 1) {
        digit = number % 10;
        number = number / 10;
    }

    digit = Math.floor(digit);
    isSeven = (digit === 7);

    document.getElementById('thirdDigitInput').value = isSeven;
}

// Problem 5. Third bit

function extractThirdBit() {
    var position = 3,
        number = document.getElementById('thirdBitInput').value,
        mask = 1,
        numberAndMask = 1,
        bit = 1;

    mask = 1 << position;
    numberAndMask = number & mask;
    bit = numberAndMask >> position;

    document.getElementById('thirdBitInput').value = 'Bit #3: ' + bit;
}

// Problem 6. Point in Circle

function isInCircle() {
    var pointX = document.getElementById('pointX').value,
        pointY = document.getElementById('pointY').value,
        centerX = 0,
        centerY = 0,
        radius = 5,
        dx = Math.abs(pointX - centerX),
        dy = Math.abs(pointY - centerY),
        isInside = (dx * dx + dy * dy) <= (radius * radius);

    document.getElementById('isInside').value = isInside;
}

// Problem 7. Is prime

function checkIfPrime() {
    var number = document.getElementById('isPrimeInput').value,
        isPrime = true,
        i = 0,
        len;

    number = Math.floor(number);

    if (number === 0 || number === 1 || number < 0) {
        isPrime = false;
    } else if (number === 2 || number === 3) {
        isPrime = true;
    } else {
        len = Math.sqrt(number);
        for (i = 2; i <= len; i += 1) {
            if ((number % i) === 0) {
                isPrime = false;
                break;
            }
        }
    }

    document.getElementById('isPrimeInput').value = isPrime;
}

// Problem 8. Trapezoid area

function trapezoidArea() {
    var sideA = document.getElementById('sideA').value,
        sideB = document.getElementById('sideB').value,
        height = document.getElementById('height').value;

    sideA = +sideA;
    sideB = +sideB;

    var area = ((sideA + sideB) / 2) * height;

    document.getElementById('trapezoidArea').value = 'Area is: ' + area;
}

// Problem 9. Point in Circle and outside Rectangle

function InCircleOutRectangle() {
    var pointX = document.getElementById('pointXTask9').value,
        pointY = document.getElementById('pointYTask9').value,
        // Circle coordinates
        centerX = 1,
        centerY = 1,
        radius = 3,
        dx = Math.abs(pointX - centerX),
        dy = Math.abs(pointY - centerY),
        // Rectangle coordinates
        bottomLeftCornerX = -1,
        bottomLeftCornerY = -1,
        topRightCornerX = 5,
        topRightCornerY = 1,
        // Check if is in circle
        isInsideCircle = (dx * dx + dy * dy) <= (radius * radius),
        // Check if is in rectangle
        isInRectangle = (pointX >= bottomLeftCornerX) && (pointX <= topRightCornerX) &&
                        (pointY >= bottomLeftCornerY) && (pointY <= topRightCornerY),
        isInCircleAndOutOfRect = isInsideCircle && !isInRectangle;

    document.getElementById('isInKAndOutR').value = isInCircleAndOutOfRect;
}
