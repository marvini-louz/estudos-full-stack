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

// ===== Tabuleiro de Xadrez

var size = 8;
var branca = "@";
var preta = "#";
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
