// Objeto - Identidade
var identidade = {
    nome: "Marcelo",
    sobrenome: "Vinícius",
    idade: 26,
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

//promise
// As Promises são uma maneira muito melhor de trabalhar com código assíncrono
// em JavaScript do que a antiga abordagem de callbacks, propensa a erros.
function getUser() {
    console.log("Recuperando informações do usuário");

    const promise1 = new Promise((resolve) => {
        setTimeout(() => {
            resolve({ id: 0, name: "Daniel", surname: "Porto" });
        }, 2000);
    });

    return promise1;
}

function getFriendList(user) {
    console.log(
        `Recuperando lista de amigos do usuário ${user.name} ${user.surname}`,
    );

    const promise2 = new Promise((resolve) => {
        setTimeout(() => {
            resolve(["joão", "bruna", "felipe", "Lira"]);
        }, 2000);
    });

    return promise2;
}

function getPhotos(username) {
    console.log(`Recuperando fotos do usuário: ${username}`);
    const promise3 = new Promise((resolve) => {
        setTimeout(() => {
            resolve(["egito", "bahamas", "maldivas", "suécia"]);
        }, 2000);
    });
    return promise3;
}

// getUser()
//     .then((user) => getFriendList(user))
//     .then((friends) => getPhotos(friends[3]))
//     .then((photos) => console.log(photos));

//Async/Await

async function displayPhotos() {
    try {
        const user = await getUser();
        const friends = await getFriendList(user);
        const photos = await getPhotos(friends[3]);
        console.log(photos);
    } catch (error) {
        console.log(error);
    } finally {
        console.log("Terminando demandas.");
    }
}

// displayPhotos();

console.log("\n\n\n");

// Factory Function
function createAccount(userName, accNumber, initalBalance) {
    return {
        name: userName,
        accNumber,
        balance: initalBalance,
        displayBalance: function () {
            console.log(`Conta: ${accNumber} \nSaldo: ${this.balance}`);
        },
    };
}
const account1 = createAccount("Marcelo", "159753-9", 20);
console.log(account1);
account1.displayBalance();

const account2 = createAccount("Vinicius", "159147-9", 2340);
console.log(account2);
account2.displayBalance();

console.log("\n\n\n");
// Objeto construtor

function Account(userName, accNumber, initialBalance) {
    this.name = userName;
    this.accNumber = accNumber;
    this.balance = initialBalance;
    this.displayBalance = function () {
        console.log(`Conta: ${accNumber} \nSaldo: ${this.balance}`);
    };
}

const acc1 = new Account("Marcelo", "159753-9", 20);
console.log(acc1);
acc1.displayBalance();
const acc2 = new Account("Vinicius", "159147-9", 2340);
console.log(acc2);
acc2.displayBalance();

//Classes

class BankAccount {
    _balance = 0;

    constructor(personName, initialBalance, address) {
        this.personName = personName;
        this._balance = initialBalance;
        this.address = address;
    }

    //impondo regras
    get balance() {
        return this._balance;
    }

    set balance(value) {
        if (Math.abs(this._balance - value) > 2000) {
            throw new Error("Não é permitido valores maiores que 2000");
        }
        if (value > this._balance) {
            throw new Error("Você não possui saldo suficiente.");
        }

        this._balance = value;
    }

    printInfo() {
        console.log(
            `Essa conta pertence a ${this.personName}, residente do endereço ${this.address}
            e possui um saldo atual de ${Number(this._balance).toFixed(2)} reais.`,
        );
    }
}

const ba1 = new BankAccount("Daniel", 2000, "Rua que sobe e desce");
