// Projeto 1 - API FILMES

const API_KEY = "daa39d7b";

const modal_overlay = document.getElementById("modal-overlay");
const modal_container = document.getElementById("modal-container");
const modal_background = document.getElementById("modal-background");
const btn_search_movie = document.getElementById("btn-search-movie");
const movie_name = document.getElementById("movie-name");
const movie_year = document.getElementById("movie-year");

async function onClickSearchMovie() {
    try {
        let url = `https://www.omdbapi.com/?apikey=${API_KEY}&t=${movieNameParameter()}&${movieYearParameter()}`;

        const response = await fetch(url);
        const data = await response.json();

        if (!response.ok) {
            throw new Error("API ERROR!");
        }

        if (data.Error) {
            throw new Error("Movie not found.");
        }

        modal_overlay.classList.add("open");
        createModalContainer(data);
    } catch (error) {
        notie.alert({ type: "error", text: error.message });
    }
}

function movieNameParameter() {
    if (movie_name.value.trim() === "") {
        throw new Error("Movie name not informed!");
    }
    return encodeURIComponent(movie_name.value.trim());
}
function movieYearParameter() {
    if (movie_year.value === "") {
        return "";
    }
    if (
        movie_year.value.length !== 4 ||
        Number(movie_year.value) <= 1888 ||
        Number.isNaN(Number(movie_year.value))
    ) {
        throw new Error("Invalid movie year.");
    }
    return `y=${movie_year.value}`;
}

function createModalContainer(data) {
    modal_container.innerHTML = `
    <div class="modal-container-body">
        <div>
            <h2 class="movie-title">${data.Title} - ${data.Year}</h2>
            <div class="movie-cover">
                <img src="${data.Poster}"
                    alt="Movie Cover">
            </div>
        </div>
        <div class="movie-infos">
            <h3 class="movie-description">${data.Plot}</h3>
            <div class="movie-cast-box">
                <p>Cast</p>
                <p class="movie-cast"> ${data.Actors}</p>
            </div>
            <div class="movie-genre-box">
                <p>Genre</p>
                <p class="movie-genre">${data.Genre}</p>
            </div>
        </div>
    </div>
    <button id="btn-add-list">
        <img src="/Javascript/assets/icons/wish-list.png" alt="Wish List">
        Wish List
    </button>
    `;
}

function onClickCloseBackground() {
    modal_overlay.classList.remove("open");
}

modal_background.addEventListener("click", onClickCloseBackground);
btn_search_movie.addEventListener("click", onClickSearchMovie);

// =-=-=-=
