// Projeto 1 - API FILMES

// import "dotenv/config";
// const API_KEY = process.env.API_KEY;

const modal_overlay = document.getElementById("modal-overlay");
const btn_search_movie = document.getElementById("btn-add-list");

function onSearchMovie() {
    modal_overlay.classList.add("open");
}

btn_search_movie.addEventListener("click", onSearchMovie);
