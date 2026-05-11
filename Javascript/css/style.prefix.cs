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
.secao__pitagoras #answer {
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

/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi4uL3Nhc3MvbWFpbi5zY3NzIiwic3R5bGUuY29tcC5jc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQVEsMEdBQUE7QUFzQ1I7OztFQUdJLHNCQUFBO0VBQ0EsU0FBQTtFQUNBLFVBQUE7QUNwQ0o7O0FEdUNBO0VBQ0ksZ0JBQUE7QUNwQ0o7O0FEdUNBO0VBQ0ksZ0NBQUE7RUFDQSxnQkFBQTtBQ3BDSjs7QUR5Q0E7RUF0REksYUFBQTtFQUNBLGlCQXNEd0I7RUFyRHhCLG1CQXFEZ0M7RUFwRGhDLHVCQW9Ed0M7RUFuRHhDLFdBbURnRDtBQ2xDcEQ7QURvQ0k7RUFDSSxnQkFBQTtBQ2xDUjtBRHFDSTtFQUNJLGtCQUFBO0VBQ0Esa0JBQUE7QUNuQ1I7QURzQ0k7RUFDSSxrQkFBQTtFQUNBLE9BQUE7RUFDQSxTQUFBO0VBQ0EsaUJBQUE7RUFDQSxhQUFBO0VBQ0Esa0NBQUE7RUFDQSxxQkFBQTtBQ3BDUjtBRHVDSTtFQUNJLFFBQUE7RUFDQSxTQUFBO0VBQ0Esb0NBQUE7RUFDQSxxQ0FBQTtFQUNBLHdDQUFBO0VBQ0Esa0JBQUE7RUFDQSxRQUFBO0VBQ0EsVUFBQTtFQUNBLHdCQUFBO0FDckNSO0FEd0NJO0VBeEZBLGFBQUE7RUFDQSxpQkF3RjRCO0VBdkY1QiwwQkF1Rm9DO0VBdEZwQyxzQkFKeUQ7RUFLekQsTUFMc0U7RUEyRmxFLGVBQUE7QUNsQ1I7QURvQ1E7RUFDSSxlQUFBO0VBQ0EsZ0JBQUE7QUNsQ1o7QURxQ1E7RUFDSSxVQUFBO0VBQ0Esa0JBQUE7RUFDQSwwQkFBQTtFQUNBLGlCQUFBO0VBQ0EsZUFBQTtBQ25DWjtBRHNDUTtFQUNJLGVBQUE7QUNwQ1o7QUR3Q0k7RUFDSSxrQkFBQTtBQ3RDUiIsImZpbGUiOiJzdHlsZS5wcmVmaXguY3MifQ== */