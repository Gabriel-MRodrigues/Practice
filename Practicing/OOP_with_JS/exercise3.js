/* 
1. Use a constructor function to implement an Electric Car (called EV) as a CHILD "class" of Car. Besides a make and current speed, the EV also has the current battery charge in % ('charge' property);
2. Implement a 'chargeBattery' method which takes an argument 'chargeTo' and sets the battery charge to 'chargeTo';
3. Implement an 'accelerate' method that will increase the car's speed by 20, and decrease the charge by 1%. Then log a message like this: 'Tesla going at 140 km/h, with a charge of 22%';
4. Create an electric car object and experiment with calling 'accelerate', 'brake' and 'chargeBattery' (charge to 90%). Notice what happens when you 'accelerate'! Polymorphism

DATA CAR 1: 'Tesla' going at 120 km/h, with a charge of 23%

*/
const CarE3 = function (make, speed) {
  this.make = make;
  this.speed = speed;
};

CarE3.prototype.accelerate = function () {
  this.speed += 10;
  console.log(`${this.make} is increasing speed: ${this.speed}`);
};

CarE3.prototype.brake = function () {
  this.speed -= 5;
  console.log(`${this.make} is decreasing speed: ${this.speed}`);
};

const EV = function (make, speed, charge) {
  CarE3.call(this, make, speed);
  this.charge = charge;
};
// linking prototypes
EV.prototype = Object.create(CarE3.prototype);

EV.prototype.chargeBattery = function (chargeTo) {
  this.charge = chargeTo;
};

EV.prototype.accelerate = function () {
  this.speed += 20;
  this.charge -= 1;
  console.log(
    `${this.make} going at ${this.speed} km/h, with a charge of ${this.charge}%`
  );
};

const tesla = new EV('Tesla', 120, 23);
console.log(tesla);

console.log(tesla.speed); // 120
tesla.chargeBattery(90);
console.log(tesla.charge); // 90
tesla.accelerate();
console.log(tesla.charge); // 89
console.log(tesla.speed); // 140
tesla.brake();
console.log(tesla.speed); // 135
