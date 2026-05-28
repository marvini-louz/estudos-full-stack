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

.api__secao__body .api__secao__main--modal-container #btn-add-list:hover, .api__secao__body .api__secao__main--modal-container #btn-add-list:active, .api__secao__body .api__secao__main .main__header__title .main__header__lista article .btn-remove-list:hover, .api__secao__body .api__secao__main .main__header__title .main__header__lista article .btn-remove-list:active, .api__secao__body .api__secao__header .header__navigate__search button:hover, .api__secao__body .api__secao__header .header__navigate__search button:active {
  cursor: pointer;
  align-self: center;
  background-color: #564787;
  transition: all ease-in 150ms;
}

.api__secao__body {
  background-color: #dbcbd8;
  padding-top: 10rem;
}
.api__secao__body .api__secao__header {
  width: 100%;
  position: fixed;
  top: 0;
  left: 0;
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
  display: flex;
  flex-flow: row;
  align-items: center;
  justify-content: center;
  gap: 1.6rem;
  flex-wrap: wrap;
  overflow-y: scroll hidden;
  width: 100%;
  height: 100%;
  max-width: 180rem;
  max-height: 70rem;
}
.api__secao__body .api__secao__main .main__header__title .main__header__lista article {
  display: flex;
  flex-flow: column;
  align-items: center;
  justify-content: center;
  gap: 1.6rem;
}
.api__secao__body .api__secao__main .main__header__title .main__header__lista article #movie-cover {
  border-radius: 0.6rem;
  height: 30rem;
}
.api__secao__body .api__secao__main .main__header__title .main__header__lista article .btn-remove-list {
  display: flex;
  flex-flow: row;
  align-items: center;
  justify-content: center;
  gap: 1.6rem;
  border-radius: 0.6rem;
  padding: 0.5rem 2rem;
}
.api__secao__body .api__secao__main .main__header__title .main__header__lista article .btn-remove-list img {
  height: 2rem;
  width: 2rem;
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
  opacity: 0;
  visibility: hidden;
  pointer-events: none;
  transition: all 0.3s ease;
}
.api__secao__body .api__secao__main--modal-overlay .modal-background {
  position: absolute;
  background-color: #564787;
  width: 100%;
  height: 100%;
  z-index: 0;
  opacity: 0.4;
}
.api__secao__body .api__secao__main #modal-overlay.open {
  opacity: 1;
  pointer-events: all;
  visibility: visible;
}
.api__secao__body .api__secao__main--modal-container {
  z-index: 1;
  display: flex;
  flex-flow: column;
  align-items: center;
  justify-content: center;
  gap: 1.6rem;
  background-color: #564787;
  padding: 2rem 10rem;
  border-radius: 1.8rem;
  max-width: 100rem;
}
.api__secao__body .api__secao__main--modal-container .modal-container-body {
  display: flex;
  flex-flow: row;
  align-items: start;
  justify-content: center;
  gap: 1.6rem;
  align-items: flex-start;
}
.api__secao__body .api__secao__main--modal-container .modal-container-body .movie-title {
  font-size: 2.3rem;
  font-weight: 700;
  line-height: 1.4;
  color: #101935;
  width: 35rem;
  overflow-wrap: break-word;
  padding: 1rem;
}
.api__secao__body .api__secao__main--modal-container .modal-container-body .movie-poster {
  width: 35rem;
  height: 50rem;
  overflow: hidden;
  border-radius: 1rem;
}
.api__secao__body .api__secao__main--modal-container .modal-container-body .movie-poster #movie-poster {
  width: 100%;
  height: 100%;
  -o-object-fit: cover;
     object-fit: cover;
  display: block;
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
.api__secao__body .api__secao__main--modal-container #btn-add-list {
  display: flex;
  flex-flow: row;
  align-items: center;
  justify-content: center;
  gap: 1.6rem;
  border-radius: 0.6rem;
  padding: 0.5rem 2rem;
}
.api__secao__body .api__secao__main--modal-container #btn-add-list img {
  height: 3rem;
  width: 3rem;
}
.secao__main__body .secao__main__container .main__container__box .container__buttons #btn-Start-Stop-Watch:link, .secao__main__body .secao__main__container .main__container__box .container__buttons #btn-Start-Stop-Watch:visited,
.secao__main__body .secao__main__container .main__container__box .container__buttons #btn-Stop-Stop-Watch:link,
.secao__main__body .secao__main__container .main__container__box .container__buttons #btn-Stop-Stop-Watch:visited,
.secao__main__body .secao__main__container .main__container__box .container__buttons #btn-Reset-Stop-Watch:link,
.secao__main__body .secao__main__container .main__container__box .container__buttons #btn-Reset-Stop-Watch:visited {
  align-self: center;
  background-color: #0b3948;
  transition: all ease-in 150ms;
}

.secao__main__body .secao__main__container .main__container__box .container__buttons #btn-Start-Stop-Watch:hover, .secao__main__body .secao__main__container .main__container__box .container__buttons #btn-Start-Stop-Watch:active,
.secao__main__body .secao__main__container .main__container__box .container__buttons #btn-Stop-Stop-Watch:hover,
.secao__main__body .secao__main__container .main__container__box .container__buttons #btn-Stop-Stop-Watch:active,
.secao__main__body .secao__main__container .main__container__box .container__buttons #btn-Reset-Stop-Watch:hover,
.secao__main__body .secao__main__container .main__container__box .container__buttons #btn-Reset-Stop-Watch:active {
  cursor: pointer;
  align-self: center;
  background-color: #0b3948;
  transition: all ease-in 150ms;
}

.secao__main__body {
  display: flex;
  flex-flow: column;
  align-items: center;
  justify-content: center;
  gap: 0;
  background-color: #416165;
}
.secao__main__body .secao__header__container {
  display: flex;
  flex-flow: column;
  align-items: center;
  justify-content: center;
  gap: 0;
}
.secao__main__body .secao__main__container {
  display: flex;
  flex-flow: column;
  align-items: center;
  justify-content: center;
  gap: 1.6rem;
}
.secao__main__body .secao__main__container .main__container__box {
  border-radius: 2rem;
  border: #778991 solid 0.1rem;
  padding: 2rem 5rem;
}
.secao__main__body .secao__main__container .main__container__box h2 {
  font-size: xx-large;
  text-align: center;
  padding: 1rem 3rem;
}
.secao__main__body .secao__main__container .main__container__box .container__stopwatch {
  display: flex;
  flex-flow: column;
  align-items: center;
  justify-content: center;
  gap: 0;
  padding: 2rem;
}
.secao__main__body .secao__main__container .main__container__box .container__stopwatch #stopwatch {
  font-size: 2rem;
}
.secao__main__body .secao__main__container .main__container__box .container__buttons {
  display: flex;
  flex-flow: row;
  align-items: center;
  justify-content: center;
  gap: 1.6rem;
  padding: 1.6rem;
}
.secao__main__body .secao__main__container .main__container__box .container__buttons #btn-Start-Stop-Watch,
.secao__main__body .secao__main__container .main__container__box .container__buttons #btn-Stop-Stop-Watch,
.secao__main__body .secao__main__container .main__container__box .container__buttons #btn-Reset-Stop-Watch {
  border: #264d57 solid 0.1rem;
  border-radius: 1rem;
  background-color: #416165;
  padding: 1.02rem 2.5rem;
}
.secao__main__body .secao__main__container .main__container__box .container__buttons .hidden {
  visibility: hidden;
}

.secao__body__container .secao__header__superior .header__menu__superior .navigate_buttons button:hover, .secao__body__container .secao__header__superior .header__menu__superior .navigate_buttons button:active {
  cursor: pointer;
  align-self: center;
  background-color: #1b9aaa;
  transition: all ease-in 150ms;
}

.secao__body__container {
  background-color: #e9e6d7;
  padding-top: 10rem;
}
.secao__body__container .secao__header__superior {
  background-color: #12282b;
  position: fixed;
  top: 0;
  width: 100%;
  z-index: 1000;
}
.secao__body__container .secao__header__superior .header__menu__superior {
  display: flex;
  flex-flow: row;
  align-items: center;
  justify-content: space-between;
  gap: 0;
  height: 10rem;
  padding: 0 3rem;
}
.secao__body__container .secao__header__superior .header__menu__superior .logo img {
  height: 10rem;
  width: auto;
}
.secao__body__container .secao__header__superior .header__menu__superior .navigate_buttons {
  display: flex;
  flex-flow: row;
  align-items: center;
  justify-content: center;
  gap: 4rem;
}
.secao__body__container .secao__header__superior .header__menu__superior .navigate_buttons button {
  all: unset;
  width: 5rem;
  height: 5rem;
  padding: 1.6rem;
  border-radius: 2rem;
  color: #faf8f1;
  font-size: 1.33rem;
  display: flex;
  gap: 1rem;
  flex-flow: column;
  align-items: center;
  justify-content: center;
}
.secao__body__container .secao__header__superior .header__menu__superior .navigate_buttons button img {
  width: 5rem;
  height: 5rem;
}
.secao__body__container .secao__main__container {
  display: flex;
  flex-flow: column;
  align-items: center;
  justify-content: center;
  gap: 0;
  padding: 2rem;
}
.secao__body__container .secao__main__container p {
  font-size: 2rem;
}
.secao__body__container .secao__main__container .secao__main__catalago {
  display: flex;
  flex-flow: row;
  align-items: center;
  justify-content: center;
  gap: 1.6rem;
  flex-wrap: wrap;
  border: solid red 1px;
  width: 170rem;
}
.secao__body__container .secao__main__container .secao__main__catalago .catalogo__lista__produtos {
  display: flex;
  flex-flow: column;
  align-items: center;
  justify-content: center;
  gap: 1.6rem;
  height: 40rem;
  width: 30rem;
}
.secao__body__container .secao__main__container .secao__main__catalago .catalogo__lista__produtos #image-box {
  border-radius: 1rem;
}
.secao__body__container .secao__main__container .secao__main__catalago .catalogo__lista__produtos #image-box img {
  max-width: 15rem;
  max-height: 30rem;
}

/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi4uL3Nhc3MvbWFpbi5zY3NzIiwic3R5bGUuY29tcC5jc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQVEsMEdBQUE7QUFxQ1I7OztFQUdJLHNCQUFBO0VBQ0EsU0FBQTtFQUNBLFVBQUE7QUNuQ0o7O0FEc0NBO0VBQ0ksZ0JBQUE7QUNuQ0o7O0FEc0NBO0VBQ0ksZ0NBQUE7RUFDQSxnQkFBQTtBQ25DSjs7QUR3Q0E7RUFyREksYUFBQTtFQUNBLGlCQXFEd0I7RUFwRHhCLG1CQW9EZ0M7RUFuRGhDLHVCQW1Ed0M7RUFsRHhDLFdBa0RnRDtBQ2pDcEQ7QURtQ0k7RUFDSSxnQkFBQTtBQ2pDUjtBRG9DSTtFQUNJLGtCQUFBO0VBQ0Esa0JBQUE7QUNsQ1I7QURtQ1E7RUFDSSxrQkFBQTtFQUNBLE9BQUE7RUFDQSxTQUFBO0VBQ0EsaUJBQUE7RUFDQSxhQUFBO0VBQ0Esa0NBQUE7RUFDQSxxQkFBQTtBQ2pDWjtBRHFDSTtFQUNJLFFBQUE7RUFDQSxTQUFBO0VBQ0Esb0NBQUE7RUFDQSxxQ0FBQTtFQUNBLHdDQUFBO0VBQ0Esa0JBQUE7RUFDQSxRQUFBO0VBQ0EsVUFBQTtFQUNBLHdCQUFBO0FDbkNSO0FEc0NJO0VBdEZBLGFBQUE7RUFDQSxpQkFzRjRCO0VBckY1QiwwQkFxRm9DO0VBcEZwQyxzQkFKeUQ7RUFLekQsTUFMc0U7RUF5RmxFLGVBQUE7QUNoQ1I7QURrQ1E7RUFDSSxlQUFBO0VBQ0EsZ0JBQUE7QUNoQ1o7QURtQ1E7RUFDSSxVQUFBO0VBQ0Esa0JBQUE7RUFDQSwwQkFBQTtFQUNBLGlCQUFBO0VBQ0EsZUFBQTtBQ2pDWjtBRG9DUTtFQUNJLGVBQUE7QUNsQ1o7QURzQ0k7RUFDSSxrQkFBQTtBQ3BDUjs7QUR3Q0E7RUFqSEksYUFBQTtFQUNBLGlCQWlId0I7RUFoSHhCLG1CQWdIZ0M7RUEvR2hDLHVCQStHd0M7RUE5R3hDLFdBOEdnRDtBQ2pDcEQ7QURtQ0k7RUFDSSxnQkFBQTtBQ2pDUjtBRG1DSTtFQUNJLGtCQUFBO0VBQ0Esa0JBQUE7QUNqQ1I7QURrQ1E7RUFDSSxrQkFBQTtFQUNBLE9BQUE7RUFDQSxTQUFBO0VBQ0EsaUJBQUE7RUFDQSxhQUFBO0VBQ0Esa0NBQUE7RUFDQSxxQkFBQTtBQ2hDWjtBRG9DSTtFQUNJLFFBQUE7RUFDQSxTQUFBO0VBQ0Esb0NBQUE7RUFDQSxxQ0FBQTtFQUNBLHdDQUFBO0VBQ0Esa0JBQUE7RUFDQSxRQUFBO0VBQ0EsVUFBQTtFQUNBLHdCQUFBO0FDbENSO0FEcUNJO0VBakpBLGFBQUE7RUFDQSxpQkFpSjRCO0VBaEo1QiwwQkFnSm9DO0VBL0lwQyxzQkFKeUQ7RUFLekQsTUFMc0U7RUFvSmxFLGVBQUE7QUMvQlI7QURpQ1E7RUFDSSxlQUFBO0VBQ0EsZ0JBQUE7QUMvQlo7QURrQ1E7RUFDSSxVQUFBO0VBQ0Esa0JBQUE7RUFDQSwwQkFBQTtFQUNBLGlCQUFBO0VBQ0EsZUFBQTtBQ2hDWjtBRG1DUTtFQUNJLGVBQUE7QUNqQ1o7QURxQ0k7RUFDSSxrQkFBQTtBQ25DUjs7QURzREE7RUFDSSxlQUFBO0VBQ0Esa0JBQUE7RUFDQSx5QkFmVztFQWdCWCw2QkFBQTtBQ25ESjs7QURzREE7RUFDSSx5QkFuQlU7RUFvQlYsa0JBQUE7QUNuREo7QURxREk7RUFDSSxXQUFBO0VBQ0EsZUFBQTtFQUNBLE1BQUE7RUFDQSxPQUFBO0FDbkRSO0FEcURRO0VBNU1KLGFBQUE7RUFDQSxjQUZ5QjtFQUd6QixtQkEyTXdDO0VBMU14Qyw2QkEwTTBEO0VBek0xRCxNQUxzRTtFQStNOUQsYUFBQTtFQUNBLHlCQWpDRztBQ2RmO0FEaURZO0VBek1SLGlCQTBNNEI7RUF6TTVCLGlCQXlNb0M7RUF4TXBDLGdCQXdNMEM7RUF2TTFDLGNBcUtVO0VBaExWLGFBQUE7RUFDQSxjQUZ5QjtFQUd6QixtQkFrTndCO0VBak54Qix1QkFrTjBCO0VBak4xQixTQWtOc0I7QUMzQzFCO0FEOENnQjtFQUNJLFdBQUE7QUM1Q3BCO0FEaURRO0VBL05KLGFBQUE7RUFDQSxjQUZ5QjtFQUd6QixtQkErTm9CO0VBOU5wQix1QkErTnNCO0VBOU50QixXQStOa0I7RUEzTmxCLGtCQTZOd0I7RUE1TnhCLGdCQTROaUM7RUEzTmpDLGdCQTJOc0M7RUExTnRDLGNBcUtVO0FDU2Q7QUQ4Q1k7RUFDSSxxQkFBQTtFQUNBLFlBQUE7RUFDQSxlQUFBO0VBQ0EsaUJBQUE7QUM1Q2hCO0FEOENZO0VBQ0ksWUFBQTtBQzVDaEI7QUQ4Q1k7RUFDSSxXQUFBO0FDNUNoQjtBRDhDWTtFQUNJLHFCQUFBO0VBQ0EsZUFBQTtFQUNBLGNBQUE7RUFDQSxhQUFBO0FDNUNoQjtBRDZDZ0I7RUFDSSxXQUFBO0FDM0NwQjtBRHNESTtFQUNJLGFBQUE7QUNwRFI7QURzRFE7RUF2UUosYUFBQTtFQUNBLGlCQXVRZ0M7RUF0UWhDLG1CQXNRd0M7RUFyUXhDLHVCQXFRZ0Q7RUFwUWhELFdBb1F3RDtFQWhReEQsa0JBaVF3QjtFQWhReEIsZ0JBZ1FpQztFQS9QakMsZ0JBK1BzQztFQTlQdEMsY0FvS1c7QUM2Q2Y7QUQrQ1k7RUEzUVIsYUFBQTtFQUNBLGNBMlFvQztFQTFRcEMsbUJBMFF5QztFQXpRekMsdUJBeVFpRDtFQXhRakQsV0F3UXlEO0VBQzdDLGVBQUE7RUFDQSx5QkFBQTtFQUNBLFdBQUE7RUFDQSxZQUFBO0VBQ0EsaUJBQUE7RUFDQSxpQkFBQTtBQ3pDaEI7QUQyQ2dCO0VBcFJaLGFBQUE7RUFDQSxpQkFvUndDO0VBblJ4QyxtQkFtUmdEO0VBbFJoRCx1QkFrUndEO0VBalJ4RCxXQWlSZ0U7QUNyQ3BFO0FEdUNvQjtFQUNJLHFCQUFBO0VBQ0EsYUFBQTtBQ3JDeEI7QUR3Q29CO0VBNVJoQixhQUFBO0VBQ0EsY0E0UjRDO0VBM1I1QyxtQkEyUmlEO0VBMVJqRCx1QkEwUnlEO0VBelJ6RCxXQXlSaUU7RUFDN0MscUJBQUE7RUFDQSxvQkFBQTtBQ2xDeEI7QURvQ3dCO0VBQ0ksWUFBQTtFQUNBLFdBQUE7QUNsQzVCO0FEOENRO0VBL1NKLGFBQUE7RUFDQSxpQkErU2dDO0VBOVNoQyxtQkE4U3dDO0VBN1N4Qyx1QkE2U2dEO0VBNVNoRCxXQTRTd0Q7RUFDaEQsZUFBQTtFQUNBLE1BQUE7RUFDQSxPQUFBO0VBQ0EsWUFBQTtFQUNBLGFBQUE7RUFDQSxVQUFBO0VBQ0Esa0JBQUE7RUFDQSxvQkFBQTtFQUNBLHlCQUFBO0FDeENaO0FEMENZO0VBQ0ksa0JBQUE7RUFDQSx5QkE5SUQ7RUErSUMsV0FBQTtFQUNBLFlBQUE7RUFDQSxVQUFBO0VBQ0EsWUFBQTtBQ3hDaEI7QUQyQ1E7RUFDSSxVQUFBO0VBQ0EsbUJBQUE7RUFDQSxtQkFBQTtBQ3pDWjtBRDRDUTtFQUNJLFVBQUE7RUEzVVIsYUFBQTtFQUNBLGlCQTJVZ0M7RUExVWhDLG1CQTBVd0M7RUF6VXhDLHVCQXlVZ0Q7RUF4VWhELFdBd1V3RDtFQUNoRCx5QkE5Skc7RUErSkgsbUJBQUE7RUFDQSxxQkFBQTtFQUNBLGlCQUFBO0FDdENaO0FEd0NZO0VBbFZSLGFBQUE7RUFDQSxjQWtWb0M7RUFqVnBDLGtCQWlWeUM7RUFoVnpDLHVCQWdWZ0Q7RUEvVWhELFdBK1V3RDtFQUM1Qyx1QkFBQTtBQ2xDaEI7QURvQ2dCO0VBOVVaLGlCQStVZ0M7RUE5VWhDLGdCQThVd0M7RUE3VXhDLGdCQTZVNkM7RUE1VTdDLGNBbUtXO0VBMEtLLFlBQUE7RUFDQSx5QkFBQTtFQUNBLGFBQUE7QUMvQnBCO0FEa0NnQjtFQUNJLFlBQUE7RUFDQSxhQUFBO0VBQ0EsZ0JBQUE7RUFDQSxtQkFBQTtBQ2hDcEI7QURrQ29CO0VBQ0ksV0FBQTtFQUNBLFlBQUE7RUFDQSxvQkFBQTtLQUFBLGlCQUFBO0VBQ0EsY0FBQTtBQ2hDeEI7QURvQ2dCO0VBM1daLGFBQUE7RUFDQSxpQkEyV3dDO0VBMVd4QyxrQkEwV2dEO0VBeldoRCx1QkF5V3VEO0VBeFd2RCxTQXdXK0Q7RUFDL0Msb0JBQUE7RUFDQSxPQUFBO0VBQ0EsZ0JBQUE7QUM5QnBCO0FEZ0NvQjtFQXpXaEIsa0JBMFdvQztFQXpXcEMsZ0JBeVc2QztFQXhXN0MsZ0JBd1drRDtFQXZXbEQsY0FzS1U7RUFrTVUsbUJBQUE7QUMzQnhCO0FENkJvQjs7RUE3V2hCLGlCQStXb0M7RUE5V3BDLGdCQThXNEM7RUE3VzVDLGdCQTZXaUQ7RUE1V2pELGNBc0tVO0FDOEtkO0FEMEJvQjs7RUF6WGhCLGFBQUE7RUFDQSxpQkEwWDRDO0VBelg1QyxrQkF5WG9EO0VBeFhwRCx1QkF3WDJEO0VBdlgzRCxXQXVYbUU7RUFuWG5FLGtCQW9Yb0M7RUFuWHBDLGdCQW1YNkM7RUFsWDdDLGdCQWtYa0Q7RUFqWGxELGNBbUtXO0FDNkxmO0FEcUJZO0VBaFlSLGFBQUE7RUFDQSxjQWdZb0M7RUEvWHBDLG1CQStYeUM7RUE5WHpDLHVCQThYaUQ7RUE3WGpELFdBNlh5RDtFQUM3QyxxQkFBQTtFQUNBLG9CQUFBO0FDZmhCO0FEaUJnQjtFQUNJLFlBQUE7RUFDQSxXQUFBO0FDZnBCO0FEcUNBOzs7OztFQUNJLGtCQUFBO0VBQ0EseUJBSlU7RUFLViw2QkFBQTtBQy9CSjs7QURpQ0E7Ozs7O0VBQ0ksZUFBQTtFQUNBLGtCQUFBO0VBQ0EseUJBVlU7RUFXViw2QkFBQTtBQzFCSjs7QUQ2QkE7RUF6YUksYUFBQTtFQUNBLGlCQXlhd0I7RUF4YXhCLG1CQXdhZ0M7RUF2YWhDLHVCQXVhd0M7RUF0YXhDLE1BTHNFO0VBNGF0RSx5QkFsQmM7QUNKbEI7QUR3Qkk7RUE3YUEsYUFBQTtFQUNBLGlCQTZhNEI7RUE1YTVCLG1CQTRhb0M7RUEzYXBDLHVCQTJhNEM7RUExYTVDLE1BTHNFO0FDNloxRTtBRHFCSTtFQWpiQSxhQUFBO0VBQ0EsaUJBaWI0QjtFQWhiNUIsbUJBZ2JvQztFQS9hcEMsdUJBK2E0QztFQTlhNUMsV0E4YW9EO0FDZnhEO0FEaUJRO0VBQ0ksbUJBQUE7RUFDQSw0QkFBQTtFQUNBLGtCQUFBO0FDZlo7QURpQlk7RUFDSSxtQkFBQTtFQUNBLGtCQUFBO0VBQ0Esa0JBQUE7QUNmaEI7QURrQlk7RUEvYlIsYUFBQTtFQUNBLGlCQStib0M7RUE5YnBDLG1CQThiNEM7RUE3YjVDLHVCQTZib0Q7RUE1YnBELE1BTHNFO0VBa2MxRCxhQUFBO0FDWmhCO0FEY2dCO0VBQ0ksZUFBQTtBQ1pwQjtBRGdCWTtFQXhjUixhQUFBO0VBQ0EsY0F3Y29DO0VBdmNwQyxtQkF1Y3lDO0VBdGN6Qyx1QkFzY2lEO0VBcmNqRCxXQXFjeUQ7RUFDN0MsZUFBQTtBQ1ZoQjtBRFlnQjs7O0VBR0ksNEJBQUE7RUFDQSxtQkFBQTtFQUNBLHlCQXhERjtFQXlERSx1QkFBQTtBQ1ZwQjtBRHFCZ0I7RUFDSSxrQkFBQTtBQ25CcEI7O0FEOENBO0VBQ0ksZUFBQTtFQUNBLGtCQUFBO0VBQ0EseUJBbEJXO0VBbUJYLDZCQUFBO0FDM0NKOztBRDhDQTtFQUNJLHlCQXJCWTtFQXNCWixrQkFBQTtBQzNDSjtBRDZDSTtFQUNJLHlCQTdCWTtFQThCWixlQUFBO0VBQ0EsTUFBQTtFQUNBLFdBQUE7RUFDQSxhQUFBO0FDM0NSO0FENkNRO0VBM2dCSixhQUFBO0VBQ0EsY0EyZ0JnQztFQTFnQmhDLG1CQTBnQnFDO0VBemdCckMsOEJBeWdCNkM7RUF4Z0I3QyxNQUxzRTtFQThnQjlELGFBQUE7RUFDQSxlQUFBO0FDdkNaO0FEeUNZO0VBQ0ksYUFBQTtFQUNBLFdBQUE7QUN2Q2hCO0FEMENZO0VBcmhCUixhQUFBO0VBQ0EsY0FxaEJvQztFQXBoQnBDLG1CQW9oQnlDO0VBbmhCekMsdUJBbWhCaUQ7RUFsaEJqRCxTQWtoQnlEO0FDcEM3RDtBRHNDZ0I7RUFDSSxVQUFBO0VBQ0EsV0FBQTtFQUNBLFlBQUE7RUFDQSxlQUFBO0VBQ0EsbUJBQUE7RUFDQSxjQWhETDtFQWlESyxrQkFBQTtFQUNBLGFBQUE7RUFDQSxTQUFBO0VBQ0EsaUJBQUE7RUFDQSxtQkFBQTtFQUNBLHVCQUFBO0FDcENwQjtBRHNDb0I7RUFDSSxXQUFBO0VBQ0EsWUFBQTtBQ3BDeEI7QURnREk7RUFwakJBLGFBQUE7RUFDQSxpQkFvakI0QjtFQW5qQjVCLG1CQW1qQm9DO0VBbGpCcEMsdUJBa2pCNEM7RUFqakI1QyxNQUxzRTtFQXVqQmxFLGFBQUE7QUMxQ1I7QUQ0Q1E7RUFDSSxlQUFBO0FDMUNaO0FENkNRO0VBNWpCSixhQUFBO0VBQ0EsY0E0akJnQztFQTNqQmhDLG1CQTJqQnFDO0VBMWpCckMsdUJBMGpCNkM7RUF6akI3QyxXQXlqQnFEO0VBQzdDLGVBQUE7RUFDQSxxQkFBQTtFQUNBLGFBQUE7QUN2Q1o7QUR5Q1k7RUFsa0JSLGFBQUE7RUFDQSxpQkFra0JvQztFQWprQnBDLG1CQWlrQjRDO0VBaGtCNUMsdUJBZ2tCb0Q7RUEvakJwRCxXQStqQjREO0VBQ2hELGFBQUE7RUFDQSxZQUFBO0FDbkNoQjtBRHFDZ0I7RUFDSSxtQkFBQTtBQ25DcEI7QURxQ29CO0VBQ0ksZ0JBQUE7RUFDQSxpQkFBQTtBQ25DeEIiLCJmaWxlIjoic3R5bGUucHJlZml4LmNzIn0= */