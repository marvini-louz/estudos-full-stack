// ===== Exercício 1
console.log("// ===== Exercício 1 \n");
const value1 = 2148;
let value2;

console.log("Primeira variável é " + value1);

value2 = 23;

console.log("Segunda variável é " + value2);

value2 = value2 ** 2;

console.log("Elevada ao quadrado é: " + value2);

value2 = value2 / 3;

console.log("Divido por 3 é: " + value2);

// ===== Exercício 2
console.log("\n// ===== Exercício 2\n");

const bool1 = true;
const bool2 = false;
const bool3 = false;

console.log("Operação 2 AND: " + (bool1 && bool2));
console.log("Operação 2 OR: " + (bool1 || bool2));
console.log("Operação 3 AND: " + (bool1 && bool2 && bool3));
console.log("Operação 3 OR: " + (bool1 || bool2 || bool3));

// ===== Exercício 3
console.log("\n// ===== Exercício 3\n");

const arrayNums = [1, 2, 3, 4, 5];
console.log(arrayNums[0]);
console.log("O valor 0 da lista é: " + arrayNums[0]);

// ===== Exercício 4
console.log("\n// ===== Exercício 4\n");

const arrayNums2 = [1, 2, 3, 4, 5];
console.log(arrayNums2[0]);

// ===== Exercício 5
console.log("\n// ===== Exercício 5\n");

function squareRoot(radicand) {
    return radicand ** (1 / 2);
}

function bhaskara(numA, numB, numC) {
    let delta = numB ** 2 - 4 * numA * numC;
    if (delta < 0) {
        return console.log("Delta negativo - tente outros valores");
    }

    let x1 = (-numB + squareRoot(delta)) / (2 * numA);
    let x2 = (-numB - squareRoot(delta)) / (2 * numA);

    console.log("X1 linha: " + x1.toFixed(2));
    console.log("X2 linha: " + x2.toFixed(2));
}

bhaskara(5, 4, -3);

// ===== Exercício 6
console.log("\n// ===== Exercício 6\n");

function mediaProvas(notas) {
    let total = 0;
    for (var i = 0; i < notas.length; i++) {
        total += notas[i];
    }
    var media = total / notas.length;

    return media;
}

console.log("A media é: " + mediaProvas([30, 30, 30, 30]));

// ===== Exercício 7
console.log("\n// ===== Exercício 7\n");

function mediaProvas2(notas, provaFinal, mediaReq) {
    let total = 0;
    const mediaRequerida = mediaReq;
    for (var i = 0; i < notas.length; i++) {
        total += notas[i];
    }
    let media = (total + provaFinal) / (notas.length + 1);

    if (media < mediaRequerida) {
        console.log("Não atingiu a média de " + mediaRequerida);
    } else {
        console.log("Média atingida com sucesso");
    }

    return media.toFixed(2);
}

console.log("A media é: " + mediaProvas2([40, 50, 40], 50, 60));

// ===== Exercício 8
console.log("\n// ===== Exercício 8\n");

function celsiusToFarenheit(graus) {
    farenheit = (9 / 5) * graus + 32;

    return console.log(graus + "°C em Farenheit é: " + farenheit);
}

celsiusToFarenheit(22);

// ===== Exercício 9
console.log("\n// ===== Exercício 9\n");

function valorAtualizado(valor) {
    const imposto = 0.08875;
    var valorComImposto = valor * (1 + imposto);

    return valorComImposto.toFixed(2);
}

console.log("Valor atualizado é: " + valorAtualizado(50));

// ===== Exercício 10
console.log("\n// ===== Exercício 10\n");

function squareRoot(radicand) {
    return radicand ** (1 / 2);
}
function hypotenuse(catA, catB) {
    //H = raiz de (c1²+c2²)
    var sum = catA ** 2 + catB ** 2;
    return squareRoot(sum);
}

console.log("Hipotenusa: " + hypotenuse(3, 4));

// ===== Exercício 11
console.log("\n// ===== Exercício 11\n");

function calcFibonacci(limite) {
    let fibonacci = [0, 1];

    while (fibonacci.at(-1) < limite) {
        let proximo = fibonacci.at(-1) + fibonacci.at(-2);

        fibonacci.push(proximo);
    }

    return fibonacci;
}

console.log(calcFibonacci(2584));

function calcFibonacci2(termos) {
    let fibonacci = [0, 1];

    if (termos <= 0) {
        return [];
    } else if (termos === 1) {
        return [0];
    }

    for (let i = 2; i < termos; i++) {
        let next = fibonacci[i - 1] + fibonacci[i - 2];

        fibonacci.push(next);
    }

    return fibonacci;
}

console.log(calcFibonacci2(5));
