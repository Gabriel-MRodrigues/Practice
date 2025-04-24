/* 
1. Re-create challenge 1, but this time using an ES6 class;
2. Add a getter called 'speedUS' which returns the current speed in mi/h (divide by 1.6);
3. Add a setter called 'speedUS' which sets the current speed in mi/h (but converts it to km/h before storing the value, by multiplying the input by 1.6);
4. Create a new car and experiment with the accelerate and brake methods, and with the getter and setter.

DATA CAR 1: 'Ford' going at 120 km/h
*/

class Car {
  constructor(make, speed) {
    this.make = make;
    this.speed = speed;
  }

  accelerate() {
    console.log((this.speed += 10));
  }

  brake() {
    console.log((this.speed -= 5));
  }

  get speedUS() {
    return (this.speed /= 1.6);
  }

  set speedUS(curSpeed) {
    curSpeed *= 1.6;
    return (this.speed = curSpeed);
  }
}

const Ford = new Car('Ford', 120);
console.log(Ford.make, Ford.speed);
console.log(Ford.speedUS);
Ford.speedUS = 50;
console.log(Ford.speed);
