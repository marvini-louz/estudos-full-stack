// ===============================
// PROJETO API DE FILMES
// ===============================

// Chave da API OMDb
const API_KEY = "daa39d7b";

// ===============================
// REFERÊNCIAS DOS ELEMENTOS HTML
// ===============================

const modal_overlay = document.getElementById("modal-overlay");
const modal_container = document.getElementById("modal-container");
const modal_background = document.getElementById("modal-background");
const btn_search_movie = document.getElementById("btn-search-movie");
const movie_name = document.getElementById("movie-name");
const movie_year = document.getElementById("movie-year");
const movies_list = document.getElementById("movies-list");

// ===============================
// LOCAL STORAGE
// ===============================

// Busca a lista salva no navegador.
// Se não existir nada salvo, retorna um array vazio.
let movie_list = JSON.parse(localStorage.getItem("movie_list")) ?? [];

// ===============================
// FUNÇÃO PRINCIPAL DE BUSCA
// ===============================

// Função assíncrona responsável por:
// - montar URL
// - fazer requisição para API
// - validar resposta
// - abrir modal
// - renderizar informações do filme
async function onClickSearchMovie() {
    try {
        // Monta URL da API com:
        // nome do filme + ano opcional
        let url = `https://www.omdbapi.com/?apikey=${API_KEY}&t=${movieNameParameter()}&${movieYearParameter()}`;

        // Faz requisição HTTP
        const response = await fetch(url);

        // Converte resposta para JSON
        const data = await response.json();

        // Verifica erro HTTP
        if (!response.ok) {
            throw new Error("API ERROR!");
        }

        // Verifica erro retornado pela própria API
        if (data.Error) {
            throw new Error("Movie not found.");
        }

        // Abre modal
        modal_overlay.classList.add("open");

        // Cria conteúdo do modal
        createModalContainer(data);
    } catch (error) {
        // Mostra alerta caso ocorra erro
        notie.alert({
            type: "error",
            text: error.message,
        });
    }
}

// ===============================
// VALIDAÇÃO DO NOME DO FILME
// ===============================

// Verifica se o usuário digitou algo
// Retorna nome tratado para URL
function movieNameParameter() {
    // Remove espaços vazios e valida
    if (movie_name.value.trim() === "") {
        throw new Error("Movie name not informed!");
    }

    // Converte caracteres especiais para URL
    return encodeURIComponent(movie_name.value.trim());
}

// ===============================
// VALIDAÇÃO DO ANO
// ===============================

// Valida:
// - campo vazio
// - quantidade de números
// - ano mínimo
// - se é número
function movieYearParameter() {
    // Caso esteja vazio, não envia ano
    if (movie_year.value === "") {
        return "";
    }

    // Validações
    if (
        movie_year.value.length !== 4 ||
        Number(movie_year.value) <= 1888 ||
        Number.isNaN(Number(movie_year.value))
    ) {
        throw new Error("Invalid movie year.");
    }

    // Retorna parâmetro da URL
    return `y=${movie_year.value}`;
}

// ===============================
// SALVAR LOCAL STORAGE
// ===============================

// Salva array movie_list no navegador
function saveListLocalStorage() {
    // Converte array para string JSON
    localStorage.setItem("movie_list", JSON.stringify(movie_list));
}

// ===============================
// CRIAR MODAL
// ===============================

// Renderiza informações do filme no modal
function createModalContainer(data) {
    // Injeta HTML do modal
    modal_container.innerHTML = `
    <div class="modal-container-body">

        <div>
            <h2 class="movie-title">${data.Title} - ${data.Year}</h2>
            <div>
                <div class="movie-poster">
                    <img id="movie-poster" src="${data.Poster}" alt="Movie Cover">
                </div>
            </div>
        </div>

        <div class="movie-infos">
            <h3 class="movie-description">${data.Plot}</h3>
            <div class="movie-cast-box">
                <p>Cast</p>
                <p class="movie-cast">${data.Actors}</p>
            </div>

            <div class="movie-genre-box">
                <p>Genre</p>
                <p class="movie-genre">${data.Genre}</p>
            </div>
        </div>
    </div>

    <button id="btn-add-list">
        <imgsrc="/Javascript/assets/icons/wish-list.png" alt="Wish List">
        Wish List
    </button>
    `;

    // Busca botão recém criado
    const btn_add_list = document.getElementById("btn-add-list");

    // Adiciona evento de clique
    btn_add_list.addEventListener("click", function () {
        // Adiciona filme à lista
        onClickAddMovieList(data);
    });
}

// ===============================
// FECHAR MODAL
// ===============================

// Remove classe open do overlay
function onClickCloseBackground() {
    modal_overlay.classList.remove("open");
}

// ===============================
// ADICIONAR FILME À LISTA
// ===============================

// Adiciona filme na lista principal
function onClickAddMovieList(data) {
    // Verifica se filme já existe
    if (isMovieInList(data.imdbID)) {
        notie.alert({
            type: "warning",
            text: "Movie already in your list.",
        });

        // Fecha modal
        onClickCloseBackground();

        return;
    }

    // Adiciona filme ao array
    movie_list.push(data);

    // Salva no navegador
    saveListLocalStorage();

    // Adiciona filme visualmente na tela
    movies_list.innerHTML += `
        <article id="movie-card-${data.imdbID}">

            <img id="movie-cover" src="${data.Poster}" alt="Movie Poster: ${data.Title}">

            <button id="btn-remove-list" class="btn-remove-list" type="button"
                onclick="onClickRemoveList('${data.imdbID}')"
            >
                <img src="/Javascript/assets/icons/remove.png">
                Remove movie
            </button>
        </article>
    `;

    // Fecha modal
    onClickCloseBackground();
}

// ===============================
// RENDERIZAR FILMES SALVOS
// ===============================

// Renderiza todos os filmes salvos
// ao atualizar a página
function renderMovies() {
    // Limpa container
    movies_list.innerHTML = "";

    // Percorre array
    movie_list.forEach((data) => {
        // Renderiza card
        movies_list.innerHTML += `
            <article id="movie-card-${data.imdbID}">

            <img id="movie-cover" src="${data.Poster}" alt="Movie Poster: ${data.Title}">

            <button id="btn-remove-list" class="btn-remove-list" type="button"
                onclick="onClickRemoveList('${data.imdbID}')"
            >
                <img src="/Javascript/assets/icons/remove.png">
                Remove movie
            </button>
        </article>
        `;
    });
}

// ===============================
// VERIFICAR FILME EXISTENTE
// ===============================

// Verifica se filme já está salvo
function isMovieInList(imdbId) {
    // Função interna usada no find()
    function isThisIDFromThisMovie(movie) {
        // Compara IDs
        return movie.imdbID === imdbId;
    }

    // Retorna:
    // objeto encontrado OU undefined
    return movie_list.find(isThisIDFromThisMovie);
}

// ===============================
// REMOVER FILME
// ===============================

// Remove filme do array e da tela
function onClickRemoveList(imdbId) {
    // Remove filme do array
    movie_list = movie_list.filter((movie) => movie.imdbID !== imdbId);

    // Remove card da tela
    document.getElementById(`movie-card-${imdbId}`).remove();

    // Atualiza localStorage
    saveListLocalStorage();
}

// ===============================
// EVENTOS
// ===============================

// Detecta Enter no input
movie_name.addEventListener("keydown", function (event) {
    // Se apertar Enter
    if (event.key === "Enter") {
        // Faz pesquisa
        onClickSearchMovie();
    }
});

// Fecha modal ao clicar no fundo
modal_background.addEventListener("click", onClickCloseBackground);

// Pesquisa ao clicar botão
btn_search_movie.addEventListener("click", onClickSearchMovie);

// Renderiza filmes salvos
// quando a página carregar
renderMovies();
