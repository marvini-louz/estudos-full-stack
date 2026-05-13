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

.api__secao__body .api__secao__header .header__navigate__search button:link, .api__secao__body .api__secao__header .header__navigate__search button:visited {
  align-self: center;
  background-color: #303030;
  border-radius: 20rem;
  padding: 1.02rem 2.5rem;
  transition: all ease-in 150ms;
}

.api__secao__body .api__secao__header .header__navigate__search button:hover, .api__secao__body .api__secao__header .header__navigate__search button:active {
  align-self: center;
  background-color: #564787;
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
.api__secao__body .api__secao__main .main__header__lista {
  overflow-y: scroll;
  width: 100%;
  height: 100%;
  max-width: 180rem;
  max-height: 70rem;
}
.api__secao__body .api__secao__main--modal-overlay {
  display: none;
}

/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi4uL3Nhc3MvbWFpbi5zY3NzIiwic3R5bGUuY29tcC5jc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQVEsMEdBQUE7QUFxQ1I7OztFQUdJLHNCQUFBO0VBQ0EsU0FBQTtFQUNBLFVBQUE7QUNuQ0o7O0FEc0NBO0VBQ0ksZ0JBQUE7QUNuQ0o7O0FEc0NBO0VBQ0ksZ0NBQUE7RUFDQSxnQkFBQTtBQ25DSjs7QUR3Q0E7RUFyREksYUFBQTtFQUNBLGlCQXFEd0I7RUFwRHhCLG1CQW9EZ0M7RUFuRGhDLHVCQW1Ed0M7RUFsRHhDLFdBa0RnRDtBQ2pDcEQ7QURtQ0k7RUFDSSxnQkFBQTtBQ2pDUjtBRG9DSTtFQUNJLGtCQUFBO0VBQ0Esa0JBQUE7QUNsQ1I7QURtQ1E7RUFDSSxrQkFBQTtFQUNBLE9BQUE7RUFDQSxTQUFBO0VBQ0EsaUJBQUE7RUFDQSxhQUFBO0VBQ0Esa0NBQUE7RUFDQSxxQkFBQTtBQ2pDWjtBRHFDSTtFQUNJLFFBQUE7RUFDQSxTQUFBO0VBQ0Esb0NBQUE7RUFDQSxxQ0FBQTtFQUNBLHdDQUFBO0VBQ0Esa0JBQUE7RUFDQSxRQUFBO0VBQ0EsVUFBQTtFQUNBLHdCQUFBO0FDbkNSO0FEc0NJO0VBdEZBLGFBQUE7RUFDQSxpQkFzRjRCO0VBckY1QiwwQkFxRm9DO0VBcEZwQyxzQkFKeUQ7RUFLekQsTUFMc0U7RUF5RmxFLGVBQUE7QUNoQ1I7QURrQ1E7RUFDSSxlQUFBO0VBQ0EsZ0JBQUE7QUNoQ1o7QURtQ1E7RUFDSSxVQUFBO0VBQ0Esa0JBQUE7RUFDQSwwQkFBQTtFQUNBLGlCQUFBO0VBQ0EsZUFBQTtBQ2pDWjtBRG9DUTtFQUNJLGVBQUE7QUNsQ1o7QURzQ0k7RUFDSSxrQkFBQTtBQ3BDUjs7QUR3Q0E7RUFqSEksYUFBQTtFQUNBLGlCQWlId0I7RUFoSHhCLG1CQWdIZ0M7RUEvR2hDLHVCQStHd0M7RUE5R3hDLFdBOEdnRDtBQ2pDcEQ7QURtQ0k7RUFDSSxnQkFBQTtBQ2pDUjtBRG1DSTtFQUNJLGtCQUFBO0VBQ0Esa0JBQUE7QUNqQ1I7QURrQ1E7RUFDSSxrQkFBQTtFQUNBLE9BQUE7RUFDQSxTQUFBO0VBQ0EsaUJBQUE7RUFDQSxhQUFBO0VBQ0Esa0NBQUE7RUFDQSxxQkFBQTtBQ2hDWjtBRG9DSTtFQUNJLFFBQUE7RUFDQSxTQUFBO0VBQ0Esb0NBQUE7RUFDQSxxQ0FBQTtFQUNBLHdDQUFBO0VBQ0Esa0JBQUE7RUFDQSxRQUFBO0VBQ0EsVUFBQTtFQUNBLHdCQUFBO0FDbENSO0FEcUNJO0VBakpBLGFBQUE7RUFDQSxpQkFpSjRCO0VBaEo1QiwwQkFnSm9DO0VBL0lwQyxzQkFKeUQ7RUFLekQsTUFMc0U7RUFvSmxFLGVBQUE7QUMvQlI7QURpQ1E7RUFDSSxlQUFBO0VBQ0EsZ0JBQUE7QUMvQlo7QURrQ1E7RUFDSSxVQUFBO0VBQ0Esa0JBQUE7RUFDQSwwQkFBQTtFQUNBLGlCQUFBO0VBQ0EsZUFBQTtBQ2hDWjtBRG1DUTtFQUNJLGVBQUE7QUNqQ1o7QURxQ0k7RUFDSSxrQkFBQTtBQ25DUjs7QUQrQ0E7RUFDSSxrQkFBQTtFQUNBLHlCQUFBO0VBQ0Esb0JBQUE7RUFDQSx1QkFBQTtFQUNBLDZCQUFBO0FDNUNKOztBRDhDQTtFQUNJLGtCQUFBO0VBQ0EseUJBZFc7QUM3QmY7O0FEOENBO0VBQ0kseUJBakJVO0FDMUJkO0FEOENRO0VBcE1KLGFBQUE7RUFDQSxjQUZ5QjtFQUd6QixtQkFtTXdDO0VBbE14Qyw2QkFrTTBEO0VBak0xRCxNQUxzRTtFQXVNOUQsYUFBQTtFQUNBLHlCQXpCRztBQ2ZmO0FEMENZO0VBak1SLGlCQWtNNEI7RUFqTTVCLGlCQWlNb0M7RUFoTXBDLGdCQWdNMEM7RUEvTDFDLGNBcUtVO0VBaExWLGFBQUE7RUFDQSxjQUZ5QjtFQUd6QixtQkEwTXdCO0VBek14Qix1QkEwTTBCO0VBek0xQixTQTBNc0I7QUNwQzFCO0FEdUNnQjtFQUNJLFdBQUE7QUNyQ3BCO0FEMENRO0VBdk5KLGFBQUE7RUFDQSxjQUZ5QjtFQUd6QixtQkF1Tm9CO0VBdE5wQix1QkF1TnNCO0VBdE50QixXQXVOa0I7RUFuTmxCLGtCQXFOd0I7RUFwTnhCLGdCQW9OaUM7RUFuTmpDLGdCQW1Oc0M7RUFsTnRDLGNBcUtVO0FDUWQ7QUR1Q1k7RUFDSSxxQkFBQTtFQUNBLFlBQUE7RUFDQSxlQUFBO0VBQ0EsaUJBQUE7QUNyQ2hCO0FEdUNZO0VBQ0ksWUFBQTtBQ3JDaEI7QUR1Q1k7RUFDSSxXQUFBO0FDckNoQjtBRHVDWTtFQUNJLHFCQUFBO0VBQ0EsZUFBQTtFQUNBLGNBQUE7RUFDQSxhQUFBO0FDckNoQjtBRHNDZ0I7RUFDSSxXQUFBO0FDcENwQjtBRG9ESTtFQUNJLGFBQUE7QUNsRFI7QURvRFE7RUFwUUosYUFBQTtFQUNBLGlCQW9RZ0M7RUFuUWhDLG1CQW1Rd0M7RUFsUXhDLHVCQWtRZ0Q7RUFqUWhELFdBaVF3RDtFQTdQeEQsa0JBOFB3QjtFQTdQeEIsZ0JBNlBpQztFQTVQakMsZ0JBNFBzQztFQTNQdEMsY0FvS1c7QUM0Q2Y7QUQ2Q1E7RUFDSSxrQkFBQTtFQUNBLFdBQUE7RUFDQSxZQUFBO0VBQ0EsaUJBQUE7RUFDQSxpQkFBQTtBQzNDWjtBRDhDUTtFQUNJLGFBQUE7QUM1Q1oiLCJmaWxlIjoic3R5bGUucHJlZml4LmNzIn0= */