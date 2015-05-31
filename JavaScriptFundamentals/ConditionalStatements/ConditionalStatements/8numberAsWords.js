function numberAsWords() {
    var remainder,
        units,
        tenths,
        hundreds,
        unitsStr = '',
        tenthsStr = '',
        hundredsStr = '',
        capitalized,
        number = document.getElementById('number').value,

    number = +number;

    if (isNaN(number) || number < 0 || number > 999) {
        document.getElementById('numberAsWordsResult').value = 'Invalid number!';
        return;
    }

    units = number % 10;
    number /= 10;
    number = number | 0;

    tenths = number % 10;
    number /= 10;
    number = number | 0;
    
    hundreds = number % 10;
    
    if (tenths === 1) {
        switch (units) {
            case 0: tenthsStr = 'ten'; break;
            case 1: tenthsStr = 'eleven'; break;
            case 2: tenthsStr = 'twelve'; break;
            case 3: tenthsStr = 'thirteen'; break;
            case 4: tenthsStr = 'fourteen'; break;
            case 5: tenthsStr = 'fifteen'; break;
            case 6: tenthsStr = 'sixteen'; break;
            case 7: tenthsStr = 'seventeen'; break;
            case 8: tenthsStr = 'eighteen'; break;
            case 9: tenthsStr = 'nineteen'; break;
            default: break;
        }
    } else {
        switch (units) {
            case 0: unitsStr = 'zero'; break;
            case 1: unitsStr = 'one'; break;
            case 2: unitsStr = 'two'; break;
            case 3: unitsStr = 'three'; break;
            case 4: unitsStr = 'four'; break;
            case 5: unitsStr = 'five'; break;
            case 6: unitsStr = 'six'; break;
            case 7: unitsStr = 'seven'; break;
            case 8: unitsStr = 'eight'; break;
            case 9: unitsStr = 'nine'; break;
            default: break;
        }

        switch (tenths) {
            case 2: tenthsStr = 'twenty'; break;
            case 3: tenthsStr = 'thirty'; break;
            case 4: tenthsStr = 'fourty'; break;
            case 5: tenthsStr = 'fifty'; break;
            case 6: tenthsStr = 'sixty'; break;
            case 7: tenthsStr = 'seventy'; break;
            case 8: tenthsStr = 'eighty'; break;
            case 9: tenthsStr = 'ninety'; break;
            default: break;
        }
    }

    switch (hundreds) {
        case 1: hundredsStr = 'one hundred'; break;
        case 2: hundredsStr = 'two hundred'; break;
        case 3: hundredsStr = 'three hundred'; break;
        case 4: hundredsStr = 'four hundred'; break;
        case 5: hundredsStr = 'five hundred'; break;
        case 6: hundredsStr = 'six hundred'; break;
        case 7: hundredsStr = 'seven hundred'; break;
        case 8: hundredsStr = 'eight hundred'; break;
        case 9: hundredsStr = 'nine hundred'; break;
        default: break;
    }
    
    if (hundreds > 0 && !tenths && !units) {
        // Print hundreds
        capitalized = capitalizeFirstLetter(hundredsStr);
        document.getElementById('numberAsWordsResult').value = capitalized;
    } else if (!hundreds && tenths > 0 && !units) {
        // Print tenths
        capitalized = capitalizeFirstLetter(tenthsStr);
        document.getElementById('numberAsWordsResult').value = capitalized;
    } else if (!hundreds && !tenths && units >= 0) {
        // Print units
        capitalized = capitalizeFirstLetter(unitsStr);
        document.getElementById('numberAsWordsResult').value = capitalized;
    } else if (hundreds > 0 && tenths > 0 && units > 0) {
        // Print all
        capitalized = capitalizeFirstLetter(hundredsStr);
        document.getElementById('numberAsWordsResult').value = capitalized + ' and ' + tenthsStr + ' ' + unitsStr;
    } else if (hundreds > 0 && tenths > 0 && !units) {
        // Print hundreds and tenths
        capitalized = capitalizeFirstLetter(hundredsStr);
        document.getElementById('numberAsWordsResult').value = capitalized + ' and ' + tenthsStr;
    } else if (hundreds > 0 && !tenths && units > 0) {
        // Print hundreds and units
        capitalized = capitalizeFirstLetter(hundredsStr);
        document.getElementById('numberAsWordsResult').value = capitalized + ' and ' + unitsStr;
    } else if (!hundreds && tenths > 0 && units > 0) {
        // Print tenths and units
        capitalized = capitalizeFirstLetter(tenthsStr);
        document.getElementById('numberAsWordsResult').value = capitalized + ' ' + unitsStr;
    }

    function capitalizeFirstLetter(string) {
        return string.charAt(0).toUpperCase() + string.slice(1);
    }
}