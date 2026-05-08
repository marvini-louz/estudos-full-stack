console.log("\n =============== Triângulo =============== \n");

// ===== Triângulo
const length = 7;
var str = "";

while (str.length < length) {
    str += "#";
    console.log(str);
}

const length2 = 7;
var str = "";
for (var i = 0; i < length2; i++) {
    str += "#";
    console.log(str);
}

console.log("\n =============== FizzBuzz =============== \n");

// ===== FizzBuzz
var max = 100;
var begin = 1;

while (begin < max) {
    if (begin % 3 == 0 && begin % 5 == 0) {
        console.log("FizzBuzz");
    } else if (begin % 5 == 0) {
        console.log("Buzz");
    } else if (begin % 3 == 0) {
        console.log("Fizz");
    } else {
        console.log(begin);
    }
    begin++;
}

for (var i = 0; i < max; i++) {
    if (begin % 3 == 0 && begin % 5 == 0) {
        console.log("FIZZBUZZ");
    } else if (begin % 3 == 0) {
        console.log("Fizz");
    } else if (begin % 5 == 0) {
        console.log("Buzz");
    } else {
        console.log(begin);
    }
    begin++;
}

console.log("\n =============== Tabuleiro =============== \n");

// ===== Tabuleiro de Xadrez

var size = 8;
var branca = " @ ";
var preta = " # ";
var linha = "";

for (var b = 0; b < size; b++) {
    //linhas

    for (var w = 0; w < size; w++) {
        //colunas
        if ((b + w) % 2 == 0) {
            linha += preta;
        } else {
            linha += branca;
        }
    }
    linha += "\n";
}
console.log(linha);

console.log("\n =============== Mínimo =============== \n");

// ===== Mínimo
var theNumber = Math.min(10, 2, 4, 5, 6, 7, 9, 12);
console.log("The min number is: " + theNumber);

console.log("\n =============== Recursão =============== \n");

// ===== Recursão
function isEven(num) {
    if (num < 0) {
        num = -num;
    }
    if (num == 0) {
        return true;
    } else if (num == 1) {
        return false;
    } else {
        return isEven(num - 2);
    }
}

console.log(isEven(50));
console.log(isEven(75));
console.log(isEven(-1));

console.log("\n =============== Count Beans =============== \n");

// ===== Count beans
function countChar(string, char) {
    var counter = 0;

    for (var i = 0; i < string.length; i++) {
        if (string.charAt(i) == char) {
            counter++;
        }
    }
    return counter;
}

function countBs(string) {
    return countChar(string, "B");
}

console.log("Amount: " + countBs("BBC"));
console.log("Amount: " + countChar("kakkerlak", "k"));

console.log("\n =============== Sum Range =============== \n");

// ===== Sum Range
function numRange(start, end, increment = 1) {
    var array = [];
    if (start < end && increment > 0) {
        for (var i = start; i <= end; i += increment) {
            array.push(i);
        }
    } else if (start > end && increment < 0) {
        for (var i = start; i >= end; i += increment) {
            array.push(i);
        }
    } else {
        return [];
    }
    return array;
}

function sumRange(array) {
    var total = 0;

    for (var i = 0; i < array.length; i++) {
        total += array[i];
    }
    return total;
}

console.log(numRange(1, 10));
console.log(sumRange(numRange(1, 10)));

console.log("\n =============== Inverter Array =============== \n");

// ===== Array inverter
var array = ["A", "B", "C", "D", "E", "F"];

function reverseArray(array) {
    return array;
}

console.log(reverseArray(array));

function reverseArrayInPlace(array) {
    return;
}

console.log(reverseArrayInPlace(numRange(1, 10)));
