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

// Métodos de Array
const listaNotas = [
    { nome: "Daniel", nota: 5 },
    { nome: "Pedro", nota: 15 },
    { nome: "Lucas", nota: 12 },
    { nome: "Fabricio", nota: 16 },
    { nome: "Izabelle", nota: 18 },
    { nome: "Nathalia", nota: 20 },
    { nome: "Marcus", nota: 12 },
    { nome: "Sergio", nota: 13 },
    { nome: "Diego", nota: 14 },
    { nome: "Renan", nota: 11 },
    { nome: "Rodrigo", nota: 9 },
    { nome: "Messi", nota: 0 },
    { nome: "CR7", nota: 0 },
];

// filter - Cria um novo array contendo apenas os itens que atendem à condição
const alunosAprovados = listaNotas.filter(function (aluno) {
    return aluno.nota >= 12;
});
console.table(alunosAprovados);

// find - Retorna o primeiro item que atende à condição especificada
const alunosQueTiraramZero = listaNotas.find(function (aluno) {
    return aluno.nota === 0;
});
console.log(alunosQueTiraramZero);

// map - Cria um novo array transformando os itens do array original
const alunosAprovadosNome = alunosAprovados.map(function (aluno) {
    return aluno.nome;
});
console.log(alunosAprovadosNome);
