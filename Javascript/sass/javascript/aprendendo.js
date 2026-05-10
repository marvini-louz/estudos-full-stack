// Objeto - Identidade
var identidade = {
    nome: "Marcelo",
    sobrenome: "Vinícius",
    Idade: 26,
    cpf: "703.033.921-50",
    função: "eletricista",
};

// Array

const investiomentoMensal = [1200, 2340, 2340, 1249, 2930, 2340];
console.log("Segundo index é: " + investiomentoMensal[1]);

// Escopos

const primeiraVariavelDoCodigo = "texto inicial";

function printToConsole() {
    const primeiraVariavelDoCodigo = "segundo texto";

    function secondFunction() {
        const primeiraVariavelDoCodigo = "terceiro texto";
        console.log("imprimindo segunda mensagem");
    }

    console.log(primeiraVariavelDoCodigo);
    secondFunction();
}

printToConsole();

// Métodos

let casa = {
    cor: "white",

    sala: 15,
    cozinha: 10,
    banheiro: 8,
    quarto: 20,

    calcularTamanhoTotalCasaEmM2: function () {
        const tamanhoTotal =
            this.sala + this.cozinha + this.banheiro + this.quarto;

        console.log(`o tamanho da casa é de ${tamanhoTotal}m²`);

        return tamanhoTotal;
    },
};

casa.calcularTamanhoTotalCasaEmM2();
