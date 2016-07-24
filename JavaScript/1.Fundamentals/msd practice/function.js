function PrintLogo() {
    console.log('------------');
    console.log('Telerik corp');
    console.log('www.telerik.com');
    console.log('------------');
}

function anotherPrint() {
    PrintLogo();
    anotherPrint(); //recursion until stack is full
}

function printSign(number) {
    if (number > 0) {
        console.log('positive');
    } else if (number < 0) {
        console.log('negative');
    } else {
        console.log('zero');
    }
}

function printMax(arr) {
    var i,
        maxIndex = 0;
    for (i = 0; i < arr.length; i += 1) {
        if (arr[maxIndex] < arr[i]) {
            maxIndex = i;
        }
    }
    console.log(arr[maxIndex] + ' is the max number in [' + arr.join(', ') + ']');
}

function printLine(start, end) {
    for (var i = start; i < end; i += 1) {
        console.log(i + ' ');
    }
}

function printArguments() {
    var i;
    console.log('===========');
    console.log(arguments.callee);

    for (i in arguments) {
        console.log([arguments[i]]);
    }
    console.log('===========');
}

function getPropertiesCount(obj) {
    var prop,
        count = 0;
    for (prop in obj) {
        count += 1;
    }
    return count;
}

function sumOdd(numbers) {
    var i,
        sum = 0;
    for (i in numbers) {
        if (numbers[i] % 2 === 1) {
            sum += numbers[i];
        }
    }
    return sum;
}

function countOccurrencies(array, value) {
    var i,
        count = 0;
    for (i = 0; i < array.length; i += 1) {
        if (array[i] === value) {
            count += 1;
        }
    }
    return count;
}

function consolePrint(num) {
    console.log('Number: ' + num);
}

function falseOverloadingPrint(number, text) {
    console.log('Number: ' + number);
    console.log('Text: ' + text);
}

//get char count
function getCharCount(string, char, isCaseSensitive) {

    function getCharCountCaseInsensitive(char) {
        var ch,
            count = 0,
            lowerChar = char.toLowerCase();
        upperChar = char.toUpperCase();

        for (ch = 0; ch < string.length; ch++) {
            if (string[ch] === lowerChar || string[ch] === upperChar) {
                count++;
            }
        }
        return count;
    }

    function getCharCountCaseSensitive(char) {
        var ch,
            count = 0;
        for (ch = 0; ch < string.length; ch++) {
            if (string[ch] === char) {
                count++;
            }
        }
        return count;
    }
    //if only two arguments case 2 or with 3 case 3 and if its true or false
    switch (arguments.length) {
        case 2:
            return getCharCountCaseInsensitive(char);
        case 3:
            return isCaseSensitive ? getCharCountCaseSensitive(char) : getCharCountCaseInsensitive(char);
    }
}
//var str = 'My name is Boncho Belutov and I am 23 years-old (Remark by Sandra: LIER, you Are 25!)';
//console.log(getCharCount(str, 'A', true));

//Overloading with Parameters Type
function specialPrint(value) {
    switch (typeof value) {
        case 'number':
            console.log('Number: ' + value);
            break;
        case 'string':
            console.log('String: "' + value + '"');
            break;
        case 'boolean':
            console.log('Boolean: ' + value);
            break;
        case undefined:
            console.log('undefined');
            break;
        case null:
            console.log('null');
            break;
        default:
        case "object":
            console.log('Object: ' + JSON.stringify(value));
            break;
    }
}
// specialPrint(5);
// specialPrint('Lorem ipsum');
// specialPrint(new Array(1, 2, 3));
// specialPrint(true);
// specialPrint(false);
// specialPrint('0');
// specialPrint(0);
// specialPrint(undefined);
// specialPrint(null);
// specialPrint(new Date(2003, 2, 3));

//contains
function contains(array, value, start, end) {
    var i;
    start = start || 0; //or
    end = end || array.length; //or  
    for (i = start; i < end; i += 1) {
        if (array[i] === value) {
            return true;
        }
    }
    return false;
}
// var arr = [1, 2, 3, 4, 5, 6, 7, 8];
// console.log(contains(arr, 5));
// console.log(contains(arr, 5, 3));
// console.log(contains(arr, 3, 0, 1));