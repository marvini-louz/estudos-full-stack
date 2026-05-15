// Cálculo da hipotenusa
const firstSideRef = document.getElementById("side-1");
const secondSideRef = document.getElementById("side-2");
const calculateButtonHypotenuse = document.getElementById(
    "calculate-hypotenuse",
);
const answerDiv = document.getElementById("answer");

function squareRoot(radicand) {
    return radicand ** (1 / 2);
}
function hypotenuse(catA, catB) {
    var sum = catA ** 2 + catB ** 2;
    return squareRoot(sum);
}

function onCalculateButtonClickHypotenuse() {
    const firstSide = firstSideRef.value;
    const secondSide = secondSideRef.value;

    console.log("function executed - hypotenuse");

    answerDiv.classList.remove("hidden-element");

    answerDiv.innerHTML = `A hipotenusa de um triangulo de lados ${firstSide} e ${secondSide} é: ${hypotenuse(
        firstSide,
        secondSide,
    )
        .toFixed(1)
        .replace(/\./g, ",")}

        <div class="left-point"></div>`;
}

calculateButtonHypotenuse.addEventListener(
    "click",
    onCalculateButtonClickHypotenuse,
);

// #region Cálculo Bhaskara
const numberA = document.getElementById("number-a");
const numberB = document.getElementById("number-b");
const numberC = document.getElementById("number-c");
const bhaskaraButton = document.getElementById("calculate-bhaskara");
const answerBhaskara = document.getElementById("answerBhaskara");

function bhaskara(numA, numB, numC) {
    let delta = numB ** 2 - 4 * numA * numC;
    if (delta < 0) {
        return "Delta negativo - tente outros valores";
    }

    let x1 = (-numB + squareRoot(delta)) / (2 * numA);
    let x2 = (-numB - squareRoot(delta)) / (2 * numA);

    return [x1.toFixed(2), x2.toFixed(2)];
}

function onCalculateButtonClickBhaskara() {
    const firstNumber = numberA.value;
    const secondNumber = numberB.value;
    const thirdNumber = numberC.value;
    const result = bhaskara(firstNumber, secondNumber, thirdNumber);

    console.log("function executed");

    answerBhaskara.classList.remove("hidden-element");

    if (typeof result === "string") {
        answerBhaskara.innerHTML = result;
        return;
    }

    const [x1, x2] = result;

    answerBhaskara.innerHTML = `
    x1 = ${x1.replace(/\./g, ",")}
    <br>
    x2 = ${x2.replace(/\./g, ",")}
    <div class="left-point"></div>
`;
}

bhaskaraButton.addEventListener("click", onCalculateButtonClickBhaskara);
// #end-region
