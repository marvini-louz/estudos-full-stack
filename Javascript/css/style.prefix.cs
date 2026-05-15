@import url("https://fonts.googleapis.com/css2?family=Cabin:ital,wght@0,400..700;1,400..700&display=swap");
*,
*:after,
*:before {
  box-sizing: border-box;
  margin: 0;
  padding: 0;
}

html {
  font-size: 62.5%;
}

body {
  font-family: "Cabin", sans-serif;
  line-height: 1.4;
}

.secao__pitagoras {
  display: flex;
  flex-flow: column;
  align-items: center;
  justify-content: center;
  gap: 1.6rem;
}
.secao__pitagoras #pythagoras {
  max-width: 60rem;
}
.secao__pitagoras .answer-container {
  position: relative;
  text-align: center;
}
.secao__pitagoras .answer-container #answer {
  position: absolute;
  top: 5%;
  left: 70%;
  font-weight: bold;
  padding: 2rem;
  border: 0.2rem solid darkslategray;
  border-radius: 0.1rem;
}
.secao__pitagoras .left-point {
  width: 0;
  height: 0;
  border-left: 0.5vh solid transparent;
  border-right: 0.5vh solid transparent;
  border-bottom: 0.5vh solid darkslateblue;
  position: absolute;
  top: 90%;
  left: -12%;
  transform: rotate(60deg);
}
.secao__pitagoras .inputs-container {
  display: flex;
  flex-flow: column;
  align-items: space-between;
  justify-content: start;
  gap: 0;
  margin: 0.5em 0;
}
.secao__pitagoras .inputs-container label {
  margin: 0.5em 0;
  font-weight: 600;
}
.secao__pitagoras .inputs-container button {
  all: unset;
  border-radius: 5px;
  background-color: darkblue;
  color: whitesmoke;
  padding: 0.25em;
}
.secao__pitagoras .inputs-container #calculate-hypotenuse {
  margin-top: 2em;
}
.secao__pitagoras .hidden-element {
  visibility: hidden;
}

.secao__bhaskara {
  display: flex;
  flex-flow: column;
  align-items: center;
  justify-content: center;
  gap: 1.6rem;
}
.secao__bhaskara #bhaskara {
  max-width: 60rem;
}
.secao__bhaskara .answerBhaskara {
  position: relative;
  text-align: center;
}
.secao__bhaskara .answerBhaskara #answer {
  position: absolute;
  top: 5%;
  left: 70%;
  font-weight: bold;
  padding: 2rem;
  border: 0.2rem solid darkslategray;
  border-radius: 0.1rem;
}
.secao__bhaskara .left-point {
  width: 0;
  height: 0;
  border-left: 0.5vh solid transparent;
  border-right: 0.5vh solid transparent;
  border-bottom: 0.5vh solid darkslateblue;
  position: absolute;
  top: 90%;
  left: -12%;
  transform: rotate(60deg);
}
.secao__bhaskara .inputs-container {
  display: flex;
  flex-flow: column;
  align-items: space-between;
  justify-content: start;
  gap: 0;
  margin: 0.5em 0;
}
.secao__bhaskara .inputs-container label {
  margin: 0.5em 0;
  font-weight: 600;
}
.secao__bhaskara .inputs-container button {
  all: unset;
  border-radius: 5px;
  background-color: darkblue;
  color: whitesmoke;
  padding: 0.25em;
}
.secao__bhaskara .inputs-container #calculate-bhaskara {
  margin-top: 2em;
}
.secao__bhaskara .hidden-element {
  visibility: hidden;
}

.api__secao__body .api__secao__main--modal-container button:link, .api__secao__body .api__secao__main--modal-container button:visited, .api__secao__body .api__secao__header .header__navigate__search button:link, .api__secao__body .api__secao__header .header__navigate__search button:visited {
  align-self: center;
  background-color: #303030;
  border-radius: 20rem;
  padding: 1.02rem 2.5rem;
  transition: all ease-in 150ms;
}

.api__secao__body .api__secao__main--modal-container button:hover, .api__secao__body .api__secao__main--modal-container button:active, .api__secao__body .api__secao__header .header__navigate__search button:hover, .api__secao__body .api__secao__header .header__navigate__search button:active {
  cursor: pointer;
  align-self: center;
  background-color: #564787;
  transition: all ease-in 150ms;
}

.api__secao__body {
  background-color: #dbcbd8;
}
.api__secao__body .api__secao__header .header__navigate__menu {
  display: flex;
  flex-flow: row;
  align-items: center;
  justify-content: space-around;
  gap: 0;
  padding: 2rem;
  background-color: #101935;
}
.api__secao__body .api__secao__header .header__navigate__menu .header__navigate__logo {
  font-size: 2.3rem;
  font-weight: bold;
  line-height: 1.4;
  color: #dbcbd8;
  display: flex;
  flex-flow: row;
  align-items: center;
  justify-content: center;
  gap: 1rem;
}
.api__secao__body .api__secao__header .header__navigate__menu .header__navigate__logo img {
  width: 5rem;
}
.api__secao__body .api__secao__header .header__navigate__search {
  display: flex;
  flex-flow: row;
  align-items: center;
  justify-content: center;
  gap: 1.6rem;
  font-size: 1.92rem;
  font-weight: 200;
  line-height: 1.4;
  color: #dbcbd8;
}
.api__secao__body .api__secao__header .header__navigate__search input {
  border-radius: 0.6rem;
  height: 3rem;
  padding: 0.5rem;
  font-size: 1.6rem;
}
.api__secao__body .api__secao__header .header__navigate__search #movie-name {
  width: 30rem;
}
.api__secao__body .api__secao__header .header__navigate__search #movie-year {
  width: 7rem;
}
.api__secao__body .api__secao__header .header__navigate__search button {
  border-radius: 0.6rem;
  padding: 0.5rem;
  height: 3.5rem;
  width: 3.5rem;
}
.api__secao__body .api__secao__header .header__navigate__search button img {
  width: 100%;
}
.api__secao__body .api__secao__main {
  padding: 2rem;
}
.api__secao__body .api__secao__main .main__header__title {
  display: flex;
  flex-flow: column;
  align-items: center;
  justify-content: center;
  gap: 1.6rem;
  font-size: 1.92rem;
  font-weight: 400;
  line-height: 1.4;
  color: #564787;
}
.api__secao__body .api__secao__main .main__header__title .main__header__lista {
  overflow-y: scroll;
  width: 100%;
  height: 100%;
  max-width: 180rem;
  max-height: 70rem;
}
.api__secao__body .api__secao__main #modal-overlay {
  display: none;
}
.api__secao__body .api__secao__main #modal-overlay.open {
  display: flex;
}
.api__secao__body .api__secao__main--modal-overlay {
  display: flex;
  flex-flow: column;
  align-items: center;
  justify-content: center;
  gap: 1.6rem;
  position: fixed;
  top: 0;
  left: 0;
  width: 100vw;
  height: 100vh;
}
.api__secao__body .api__secao__main--modal-overlay .modal-background {
  position: absolute;
  background-color: #564787;
  width: 100%;
  height: 100%;
  z-index: 0;
  opacity: 0.4;
}
.api__secao__body .api__secao__main--modal-container {
  z-index: 1;
  display: flex;
  flex-flow: column;
  align-items: center;
  justify-content: center;
  gap: 1.6rem;
  background-color: #564787;
  padding: 2rem 4rem;
  border-radius: 1.8rem;
  max-width: 100rem;
}
.api__secao__body .api__secao__main--modal-container .modal-container-body {
  display: flex;
  flex-flow: row;
  align-items: start;
  justify-content: center;
  gap: 1.6rem;
}
.api__secao__body .api__secao__main--modal-container .modal-container-body .movie-title {
  font-size: 2.3rem;
  font-weight: 700;
  line-height: 1.4;
  color: #101935;
  padding: 1rem;
}
.api__secao__body .api__secao__main--modal-container .modal-container-body .movie-cover {
  flex: 1;
}
.api__secao__body .api__secao__main--modal-container .modal-container-body .movie-cover img {
  max-width: 35rem;
  border-radius: 1rem;
}
.api__secao__body .api__secao__main--modal-container .modal-container-body .movie-infos {
  display: flex;
  flex-flow: column;
  align-items: start;
  justify-content: center;
  gap: 3rem;
  padding: 25rem 0 0 0;
  flex: 1;
  max-width: 40rem;
}
.api__secao__body .api__secao__main--modal-container .modal-container-body .movie-infos .movie-description {
  font-size: 1.92rem;
  font-weight: 900;
  line-height: 1.4;
  color: #f2fdff;
  text-align: justify;
}
.api__secao__body .api__secao__main--modal-container .modal-container-body .movie-infos .movie-cast,
.api__secao__body .api__secao__main--modal-container .modal-container-body .movie-infos .movie-genre {
  font-size: 1.6rem;
  font-weight: 200;
  line-height: 1.4;
  color: #f2fdff;
}
.api__secao__body .api__secao__main--modal-container .modal-container-body .movie-infos .movie-cast-box,
.api__secao__body .api__secao__main--modal-container .modal-container-body .movie-infos .movie-genre-box {
  display: flex;
  flex-flow: column;
  align-items: start;
  justify-content: center;
  gap: 0.2rem;
  font-size: 1.92rem;
  font-weight: 800;
  line-height: 1.4;
  color: #101935;
}
.api__secao__body .api__secao__main--modal-container button {
  display: flex;
  flex-flow: row;
  align-items: center;
  justify-content: center;
  gap: 1.6rem;
  border-radius: 0.6rem;
  padding: 0.5rem 2rem;
}
.api__secao__body .api__secao__main--modal-container button img {
  height: 3rem;
  width: 3rem;
}

/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi4uL3Nhc3MvbWFpbi5zY3NzIiwic3R5bGUuY29tcC5jc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQVEsMEdBQUE7QUFxQ1I7OztFQUdJLHNCQUFBO0VBQ0EsU0FBQTtFQUNBLFVBQUE7QUNuQ0o7O0FEc0NBO0VBQ0ksZ0JBQUE7QUNuQ0o7O0FEc0NBO0VBQ0ksZ0NBQUE7RUFDQSxnQkFBQTtBQ25DSjs7QUR3Q0E7RUFyREksYUFBQTtFQUNBLGlCQXFEd0I7RUFwRHhCLG1CQW9EZ0M7RUFuRGhDLHVCQW1Ed0M7RUFsRHhDLFdBa0RnRDtBQ2pDcEQ7QURtQ0k7RUFDSSxnQkFBQTtBQ2pDUjtBRG9DSTtFQUNJLGtCQUFBO0VBQ0Esa0JBQUE7QUNsQ1I7QURtQ1E7RUFDSSxrQkFBQTtFQUNBLE9BQUE7RUFDQSxTQUFBO0VBQ0EsaUJBQUE7RUFDQSxhQUFBO0VBQ0Esa0NBQUE7RUFDQSxxQkFBQTtBQ2pDWjtBRHFDSTtFQUNJLFFBQUE7RUFDQSxTQUFBO0VBQ0Esb0NBQUE7RUFDQSxxQ0FBQTtFQUNBLHdDQUFBO0VBQ0Esa0JBQUE7RUFDQSxRQUFBO0VBQ0EsVUFBQTtFQUNBLHdCQUFBO0FDbkNSO0FEc0NJO0VBdEZBLGFBQUE7RUFDQSxpQkFzRjRCO0VBckY1QiwwQkFxRm9DO0VBcEZwQyxzQkFKeUQ7RUFLekQsTUFMc0U7RUF5RmxFLGVBQUE7QUNoQ1I7QURrQ1E7RUFDSSxlQUFBO0VBQ0EsZ0JBQUE7QUNoQ1o7QURtQ1E7RUFDSSxVQUFBO0VBQ0Esa0JBQUE7RUFDQSwwQkFBQTtFQUNBLGlCQUFBO0VBQ0EsZUFBQTtBQ2pDWjtBRG9DUTtFQUNJLGVBQUE7QUNsQ1o7QURzQ0k7RUFDSSxrQkFBQTtBQ3BDUjs7QUR3Q0E7RUFqSEksYUFBQTtFQUNBLGlCQWlId0I7RUFoSHhCLG1CQWdIZ0M7RUEvR2hDLHVCQStHd0M7RUE5R3hDLFdBOEdnRDtBQ2pDcEQ7QURtQ0k7RUFDSSxnQkFBQTtBQ2pDUjtBRG1DSTtFQUNJLGtCQUFBO0VBQ0Esa0JBQUE7QUNq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 */