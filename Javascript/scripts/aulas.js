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

// ===== Exercício 12
console.log("\n// ===== Exercício 12\n");

const vendas = [23, 23, 4, 56, 76, 4, 56];
const custo = 10;

function calcularVendas(vendasPordia, custoHamburguer) {
    let total = 0;
    for (let i = 0; i < vendasPordia.length; i++) {
        total += vendasPordia[i] * custoHamburguer;
    }
    return total;
}
var totalVendas = calcularVendas(vendas, custo);
console.log("Total: " + totalVendas);

// ===== Exercício 13
console.log("\n// ===== Exercício 13\n");

const cardapio = [
    { item: "carne assada", valor: 40 },
    { item: "arroz frito", valor: 25 },
    { item: "feijão tropeiro", valor: 30 },
    { item: "batata frita", valor: 12 },
];

function exibirCardapio(cardapio) {
    console.log("Este é nosso cardápio: ");
    for (let i = 0; i < cardapio.length; i++) {
        console.log(cardapio[i].item + ": ", cardapio[i].valor);
    }
}
exibirCardapio(cardapio);

// ===== Exercício 14
console.log("\n// ===== Exercício 14\n");

const vendasDiarias = [123, 142345, 34, 63457, 46, 568];

function calcularRenda(vendasDiarias) {
    let recebidos = 0;

    for (var i = 0; i < vendasDiarias.length; i++) {
        recebidos += vendasDiarias[i];
    }
    console.log("Total R$ " + recebidos.toFixed(2));
}
calcularRenda(vendasDiarias);

let vendasDiarias2 = 5;
function calcularRenda2(vendasDiarias2) {
    let recebidos = 0;
    let vendas = 0;
    let finalizada = false;

    while (!finalizada) {
        const valor = 20;
        recebidos += valor;
        vendas++;

        if (vendas >= vendasDiarias2) {
            finalizada = true;
        }
    }
    console.log("Total R$ " + recebidos.toFixed(2));
}
calcularRenda2(vendasDiarias2);

// ===== Exercício 15
console.log("\n// ===== Exercício 15\n");

const listaPedidos = [
    "pedido 1",
    "pedido 2",
    "pedido 3",
    "pedido 4",
    "pedido 1",
    "pedido 2",
    "pedido 3",
    "pedido 4",
];

function entregarPedido(listaPedidos) {
    for (var i = 0; i < listaPedidos.length; i++) {
        console.log("Pedido entregue: " + listaPedidos[i]);
    }
}
entregarPedido(listaPedidos);

const listaPedidos2 = [
    "pedido 1",
    "pedido 2",
    "pedido 3",
    "pedido 4",
    "pedido 1",
    "pedido 2",
    "pedido 3",
    "pedido 4",
];

function entregarPedido2(listaPedidos) {
    let pedidoAtual = "";
    console.log("\nIniciando entregas...");

    while (listaPedidos.length > 0) {
        pedidoAtual = listaPedidos.shift();
        console.log("Pedido atual: " + pedidoAtual);
    }
    console.log("Entrgas finalizadas...");
}
entregarPedido2(listaPedidos2);

// ===== Exercício 16
console.log("\n// ===== Exercício 16\n");

function advinharNumero() {
    const numero = Math.floor(Math.random() * 10);
    let tentativa;
    let chances = 0;

    do {
        tentativa = Math.floor(Math.random() * 10);
        chances++;

        if (tentativa === numero) {
            console.log("Parabéns!! tentativas: " + tentativa);
        }
    } while (tentativa !== numero);
}

advinharNumero();
