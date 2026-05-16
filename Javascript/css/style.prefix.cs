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
.api__secao__body .api__secao__main .main__header__title .main__header__lista article img {
  max-width: 25rem;
  border-radius: 1rem;
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

/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi4uL3Nhc3MvbWFpbi5zY3NzIiwic3R5bGUuY29tcC5jc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQVEsMEdBQUE7QUFxQ1I7OztFQUdJLHNCQUFBO0VBQ0EsU0FBQTtFQUNBLFVBQUE7QUNuQ0o7O0FEc0NBO0VBQ0ksZ0JBQUE7QUNuQ0o7O0FEc0NBO0VBQ0ksZ0NBQUE7RUFDQSxnQkFBQTtBQ25DSjs7QUR3Q0E7RUFyREksYUFBQTtFQUNBLGlCQXFEd0I7RUFwRHhCLG1CQW9EZ0M7RUFuRGhDLHVCQW1Ed0M7RUFsRHhDLFdBa0RnRDtBQ2pDcEQ7QURtQ0k7RUFDSSxnQkFBQTtBQ2pDUjtBRG9DSTtFQUNJLGtCQUFBO0VBQ0Esa0JBQUE7QUNsQ1I7QURtQ1E7RUFDSSxrQkFBQTtFQUNBLE9BQUE7RUFDQSxTQUFBO0VBQ0EsaUJBQUE7RUFDQSxhQUFBO0VBQ0Esa0NBQUE7RUFDQSxxQkFBQTtBQ2pDWjtBRHFDSTtFQUNJLFFBQUE7RUFDQSxTQUFBO0VBQ0Esb0NBQUE7RUFDQSxxQ0FBQTtFQUNBLHdDQUFBO0VBQ0Esa0JBQUE7RUFDQSxRQUFBO0VBQ0EsVUFBQTtFQUNBLHdCQUFBO0FDbkNSO0FEc0NJO0VBdEZBLGFBQUE7RUFDQSxpQkFzRjRCO0VBckY1QiwwQkFxRm9DO0VBcEZwQyxzQkFKeUQ7RUFLekQsTUFMc0U7RUF5RmxFLGVBQUE7QUNoQ1I7QURrQ1E7RUFDSSxlQUFBO0VBQ0EsZ0JBQUE7QUNoQ1o7QURtQ1E7RUFDSSxVQUFBO0VBQ0Esa0JBQUE7RUFDQSwwQkFBQTtFQUNBLGlCQUFBO0VBQ0EsZUFBQTtBQ2pDWjtBRG9DUTtFQUNJLGVBQUE7QUNsQ1o7QURzQ0k7RUFDSSxrQkFBQTtBQ3BDUjs7QUR3Q0E7RUFqSEksYUFBQTtFQUNBLGlCQWlId0I7RUFoSHhCLG1CQWdIZ0M7RUEvR2hDLHVCQStHd0M7RUE5R3hDLFdBOEdnRDtBQ2pDcEQ7QURtQ0k7RUFDSSxnQkFBQTtBQ2pDUjtBRG1DSTtFQUNJLGtCQUFBO0VBQ0Esa0JBQUE7QUNq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O0VBQ0EsT0FBQTtFQUNBLFlBQUE7RUFDQSxhQUFBO0VBQ0EsVUFBQTtFQUNBLGtCQUFBO0VBQ0Esb0JBQUE7RUFDQSx5QkFBQTtBQ3ZDWjtBRHlDWTtFQUNJLGtCQUFBO0VBQ0EseUJBN0lEO0VBOElDLFdBQUE7RUFDQSxZQUFBO0VBQ0EsVUFBQTtFQUNBLFlBQUE7QUN2Q2hCO0FEMkNRO0VBQ0ksVUFBQTtFQUNBLG1CQUFBO0VBQ0EsbUJBQUE7QUN6Q1o7QUQ0Q1E7RUFDSSxVQUFBO0VBM1VSLGFBQUE7RUFDQSxpQkEyVWdDO0VBMVVoQyxtQkEwVXdDO0VBelV4Qyx1QkF5VWdEO0VBeFVoRCxXQXdVd0Q7RUFDaEQseUJBOUpHO0VBK0pILG1CQUFBO0VBQ0EscUJBQUE7RUFDQSxpQkFBQTtBQ3RDWjtBRHdDWTtFQWxWUixhQUFBO0VBQ0EsY0FrVm9DO0VBalZwQyxrQkFpVnlDO0VBaFZ6Qyx1QkFnVmdEO0VBL1VoRCxXQStVd0Q7QUNsQzVEO0FEb0NnQjtFQTdVWixpQkE4VWdDO0VBN1VoQyxnQkE2VXdDO0VBNVV4QyxnQkE0VTZDO0VBM1U3QyxjQW1LVztFQXlLSyxhQUFBO0FDL0JwQjtBRGtDZ0I7RUFDSSxPQUFBO0FDaENwQjtBRGtDb0I7RUFDSSxnQkFBQTtFQUNBLG1CQUFBO0FDaEN4QjtBRG9DZ0I7RUFuV1osYUFBQTtFQUNBLGlCQW1Xd0M7RUFsV3hDLGtCQWtXZ0Q7RUFqV2hELHVCQWlXdUQ7RUFoV3ZELFNBZ1crRDtFQUMvQyxvQkFBQTtFQUNBLE9BQUE7RUFDQSxnQkFBQTtBQzlCcEI7QURnQ29CO0VBaldoQixrQkFrV29DO0VBaldwQyxnQkFpVzZDO0VBaFc3QyxnQkFnV2tEO0VBL1ZsRCxjQXNLVTtFQTBMVSxtQkFBQTtBQzNCeEI7QUQ2Qm9COztFQXJXaEIsaUJBdVdvQztFQXRXcEMsZ0JBc1c0QztFQXJXNUMsZ0JBcVdpRDtFQXBXakQsY0FzS1U7QUNzS2Q7QUQwQm9COztFQWpYaEIsYUFBQTtFQUNBLGlCQWtYNEM7RUFqWDVDLGtCQWlYb0Q7RUFoWHBELHVCQWdYMkQ7RUEvVzNELFdBK1dtRTtFQTNXbkUsa0JBNFdvQztFQTNXcEMsZ0JBMlc2QztFQTFXN0MsZ0JBMFdrRDtFQXpXbEQsY0FtS1c7QUNxTGY7QURxQlk7RUF4WFIsYUFBQTtFQUNBLGNBd1hvQztFQXZYcEMsbUJBdVh5QztFQXRYekMsdUJBc1hpRDtFQXJYakQsV0FxWHlEO0VBQzdDLHFCQUFBO0VBQ0Esb0JBQUE7QUNmaEI7QURpQmdCO0VBQ0ksWUFBQTtFQUNBLFdBQUE7QUNmcEIiLCJmaWxlIjoic3R5bGUucHJlZml4LmNzIn0= */