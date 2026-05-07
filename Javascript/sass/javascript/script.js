console.log("script do body");

// prompt("Tell me everything you know.", "...");

// ===== Objetos
var obj = {
    nonme: "Marcelo",
    idade: 26,
    cargo: "dev",
    trabalha: True,
};
//acessar propriedades
console.log("Nome do objeto é" + obj.nome);

//alterar valor de propriedades
obj.cargo = "eletricista";

//criar mais propriedades
obj.graduacao = "engenheiro";

// ===== Arrays

var arr = [69, "marcelo", True, { curso: "js", type: "arrays" }];
var arrNum = [0, 2, 4, 6, 8];

//acessando index
console.log("posição 1 do array: " + arr[0] + "última posição: " + arr[-1]);

//adiconando valor em array
arrNum[-1] = 35;
//altera valor em array
arr[0] = 70;

// ===== Fluxos condicionais
// if else
var theNumber = Number(prompt("Pick a number", ""));
if (!isNaN(theNumber)) alert("the square root of " + theNumber * theNumber);
else alert("Hey. Why didn't you give me a number?");

// switch
switch (prompt("What is the weather like?")) {
    case "rainy":
        console.log("Remember to bring an umbrella.");
        break;
    case "sunny":
        console.log("Dress lightly.");
    case "cloudy":
        console.log("Go outside.");
        break;
    default:
        console.log("Unknown weather type!");
        break;
}
