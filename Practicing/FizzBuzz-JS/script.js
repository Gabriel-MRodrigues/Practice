let inputNum;
let inputFizz;
let inputBuzz;
let output;

//I'm using a while loop here because I want the user to keep typing the Number until the system gets an Integer number greater than 0 and also not a string.
//Instead of refreshing the page to generate a prompt message again, the while loop keeps generating it until the user inserts a valid number for each case.
//It looks a bit messy but that is the way I figure it out to keep running the messages. (I don't know if there is a better way to do it using only onw while...)

while (inputNum <= 0 || !parseInt(inputNum)) {
  inputNum = prompt("Enter a Number:");

  if (parseInt(inputNum) && inputNum > 0) {
    while (inputFizz <= 0 || !parseInt(inputFizz)) {
      inputFizz = prompt("Enter a 'Fizz Number:");

      if (parseInt(inputFizz) && inputFizz > 0) {
        while (inputBuzz <= 0 || !parseInt(inputBuzz)) {
          inputBuzz = prompt("Enter a 'Buzz' Number:");

          if (parseInt(inputBuzz) && inputBuzz > 0) {
            for (let i = 1; i <= inputNum; i++) {
              if (i % inputFizz == 0 && i % inputBuzz != 0) {
                output = "Fizz";
                document.write(output + "<br>");
              } else if (i % inputBuzz == 0 && i % inputFizz != 0) {
                output = "Buzz";
                document.write(output + "<br>");
              } else if (i % inputFizz == 0 && i % inputBuzz == 0) {
                output = "FizzBuzz";
                document.write(output + "<br>");
              } else {
                document.write(i + "<br>");
              }
            }
          } else {
            alert(
              "You must insert a valid number for 'Buzz'. It must be an Integer greater than 0"
            );
          }
        }
      } else {
        alert(
          "You must insert a valid number for 'Fizz'. It must be an Integer greater than 0"
        );
      }
    }
  } else {
    alert(
      "You must insert a valid Number. It must be an Integer Number greater than 0"
    );
  }
}
