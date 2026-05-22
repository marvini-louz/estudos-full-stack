const btnStartStopwatch = document.getElementById("btn-Start-Stop-Watch");
const btnStopStopwatch = document.getElementById("btn-Stop-Stop-Watch");
const btnResetStopwatch = document.getElementById("btn-Reset-Stop-Watch");
const display = document.getElementById("stopwatch");

class Stopwatch {
    //membro privado de uma classe, só é acessado dentro da classe
    #elapsedTimeSeconds = 0;
    #intervalId = null;

    start() {
        if (this.#intervalId !== null) {
            return;
        }

        this.#intervalId = setInterval(() => {
            this.#elapsedTimeSeconds++;
            // console.log(this.elapsedTime); //debug
        }, 1000);
    }

    stop() {
        clearInterval(this.#intervalId);
        this.#intervalId = null;
    }

    reset() {
        this.stop();
        this.#elapsedTimeSeconds = 0;
    }

    get elapsedTime() {
        return Stopwatch.formatTime(this.#elapsedTimeSeconds);
    }

    static formatTime(timeInSeconds) {
        const hours = Math.floor(timeInSeconds / 3600);
        const minutes = Math.floor((timeInSeconds % 3600) / 60);
        const seconds = timeInSeconds - hours * 3600 - minutes * 60;

        return `${Stopwatch.zeroPadding(hours)}:${Stopwatch.zeroPadding(minutes)}:${Stopwatch.zeroPadding(seconds)}`;
    }

    static zeroPadding(originalNum, amountDigits = 2) {
        let stringNum = String(originalNum);
        const zeros = amountDigits - stringNum.length;

        if (zeros <= 0) {
            return stringNum;
        }

        for (let i = 0; i < zeros; i++) {
            stringNum = `0${stringNum}`;
        }
        return stringNum;
    }
}

const sw1 = new Stopwatch();
setInterval(() => {
    display.textContent = sw1.elapsedTime;
}, 100);

btnStartStopwatch.addEventListener("click", () => sw1.start());
btnStopStopwatch.addEventListener("click", () => sw1.stop());
btnResetStopwatch.addEventListener("click", () => sw1.reset());
