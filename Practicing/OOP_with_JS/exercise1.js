/* 
1. Use a constructor function to implement a Car. A car has a make and a speed property. The speed property is the current speed of the car in km/h;
2. Implement an 'accelerate' method that will increase the car's speed by 10, and log the new speed to the console;
3. Implement a 'brake' method that will decrease the car's speed by 5, and log the new speed to the console;

DATA CAR 1: 'BMW' going at 120 km/h
DATA CAR 2: 'Mercedes' going at 95 km/h */

const Car = function (make, speed) {
  (this.Make = make), (this.Speed = speed);
};

const car1 = new Car('BMW', 120);
const car2 = new Car('Mercedes', 95);

Car.prototype.accelerate = function () {
  console.log((this.Speed += 10));
};

Car.prototype.brake = function () {
  console.log((this.Speed -= 5));
};

car1.accelerate();
car1.accelerate();
car2.brake();
car2.accelerate();
car1.brake();
car1.accelerate();
