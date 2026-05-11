// Cálculo da hipotenusa
const firstSideRef = document.getElementById("side-1");
const secondSideRef = document.getElementById("side-2");
const calculateButton = document.getElementById("calculate-hypotenuse");
const answerDiv = document.getElementById("answer");

function squareRoot(radicand) {
    return radicand ** (1 / 2);
}
function hypotenuse(catA, catB) {
    var sum = catA ** 2 + catB ** 2;
    return squareRoot(sum);
}

function onCalculateButtonClick() {
    const firstSide = firstSideRef.value;
    const secondSide = secondSideRef.value;

    console.log("function executed");

    answerDiv.classList.remove("hidden-element");

    answerDiv.innerHTML = `A hipotenusa de um triangulo de lados ${firstSide} e ${secondSide} é: ${hypotenuse(
        firstSide,
        secondSide,
    )
        .toFixed(1)
        .replace(/\./g, ",")}

        <div class="left-point"></div>`;
}

calculateButton.addEventListener("click", onCalculateButtonClick);
