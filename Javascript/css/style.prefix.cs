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

/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi4uL3Nhc3MvbWFpbi5zY3NzIiwic3R5bGUuY29tcC5jc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQVEsMEdBQUE7QUFzQ1I7OztFQUdJLHNCQUFBO0VBQ0EsU0FBQTtFQUNBLFVBQUE7QUNwQ0o7O0FEdUNBO0VBQ0ksZ0JBQUE7QUNwQ0o7O0FEdUNBO0VBQ0ksZ0NBQUE7RUFDQSxnQkFBQTtBQ3BDSjs7QUR5Q0E7RUF0REksYUFBQTtFQUNBLGlCQXNEd0I7RUFyRHhCLG1CQXFEZ0M7RUFwRGhDLHVCQW9Ed0M7RUFuRHhDLFdBbURnRDtBQ2xDcEQ7QURvQ0k7RUFDSSxnQkFBQTtBQ2xDUjtBRHFDSTtFQUNJLGtCQUFBO0VBQ0Esa0JBQUE7QUNuQ1I7QURvQ1E7RUFDSSxrQkFBQTtFQUNBLE9BQUE7RUFDQSxTQUFBO0VBQ0EsaUJBQUE7RUFDQSxhQUFBO0VBQ0Esa0NBQUE7RUFDQSxxQkFBQTtBQ2xDWjtBRHNDSTtFQUNJLFFBQUE7RUFDQSxTQUFBO0VBQ0Esb0NBQUE7RUFDQSxxQ0FBQTtFQUNBLHdDQUFBO0VBQ0Esa0JBQUE7RUFDQSxRQUFBO0VBQ0EsVUFBQTtFQUNBLHdCQUFBO0FDcENSO0FEdUNJO0VBdkZBLGFBQUE7RUFDQSxpQkF1RjRCO0VBdEY1QiwwQkFzRm9DO0VBckZwQyxzQkFKeUQ7RUFLekQsTUFMc0U7RUEwRmxFLGVBQUE7QUNqQ1I7QURtQ1E7RUFDSSxlQUFBO0VBQ0EsZ0JBQUE7QUNqQ1o7QURvQ1E7RUFDSSxVQUFBO0VBQ0Esa0JBQUE7RUFDQSwwQkFBQTtFQUNBLGlCQUFBO0VBQ0EsZUFBQTtBQ2xDWjtBRHFDUTtFQUNJLGVBQUE7QUNuQ1o7QUR1Q0k7RUFDSSxrQkFBQTtBQ3JDUjs7QUR5Q0E7RUFsSEksYUFBQTtFQUNBLGlCQWtId0I7RUFqSHhCLG1CQWlIZ0M7RUFoSGhDLHVCQWdId0M7RUEvR3hDLFdBK0dnRDtBQ2xDcEQ7QURvQ0k7RUFDSSxnQkFBQTtBQ2xDUjtBRG9DSTtFQUNJLGtCQUFBO0VBQ0Esa0JBQUE7QUNsQ1I7QURtQ1E7RUFDSSxrQkFBQTtFQUNBLE9BQUE7RUFDQSxTQUFBO0VBQ0EsaUJBQUE7RUFDQSxhQUFBO0VBQ0Esa0NBQUE7RUFDQSxxQkFBQTtBQ2pDWjtBRHFDSTtFQUNJLFFBQUE7RUFDQSxTQUFBO0VBQ0Esb0NBQUE7RUFDQSxxQ0FBQTtFQUNBLHdDQUFBO0VBQ0Esa0JBQUE7RUFDQSxRQUFBO0VBQ0EsVUFBQTtFQUNBLHdCQUFBO0FDbkNSO0FEc0NJO0VBbEpBLGFBQUE7RUFDQSxpQkFrSjRCO0VBako1QiwwQkFpSm9DO0VBaEpwQyxzQkFKeUQ7RUFLekQsTUFMc0U7RUFxSmxFLGVBQUE7QUNoQ1I7QURrQ1E7RUFDSSxlQUFBO0VBQ0EsZ0JBQUE7QUNoQ1o7QURtQ1E7RUFDSSxVQUFBO0VBQ0Esa0JBQUE7RUFDQSwwQkFBQTtFQUNBLGlCQUFBO0VBQ0EsZUFBQTtBQ2pDWjtBRG9DUTtFQUNJLGVBQUE7QUNsQ1o7QURzQ0k7RUFDSSxrQkFBQTtBQ3BDUiIsImZpbGUiOiJzdHlsZS5wcmVmaXguY3MifQ== */