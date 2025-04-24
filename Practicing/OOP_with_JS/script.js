// This file is dedicated to learn OOP in JavaScript.
// Instead of using classes (like in C#), JavaScript is based on prototypes
// When you try to access a property on an object and it doesn’t exist, JavaScript will look up the prototype chain to find it.

// Constructor Functions and the new Operator
const Person = function (firstName, birthYear) {
  // Instance properties
  this.firstName = firstName;
  this.birthYear = birthYear;

  // Never do this!
  // this.calcAge = function () {
  //   console.log(2037 - this.birthYear);
  // };
};

const jonas = new Person('Jonas', 1991);
console.log(jonas);

// 1. New {} is created
// 2. function is called, this = {}
// 3. {} linked to prototype
// 4. function automatically return {}

const matilda = new Person('Matilda', 2017);
const jack = new Person('Jack', 1975);

console.log(jonas instanceof Person);

Person.hey = function () {
  console.log('Hey there 👋');
  console.log(this);
};
Person.hey();

///////////////////////////////////////
// Prototypes
console.log(Person.prototype);

Person.prototype.calcAge = function () {
  console.log(2037 - this.birthYear);
};

jonas.calcAge();
matilda.calcAge();

console.log(jonas.__proto__);
console.log(jonas.__proto__ === Person.prototype);

console.log(Person.prototype.isPrototypeOf(jonas));
console.log(Person.prototype.isPrototypeOf(matilda));
console.log(Person.prototype.isPrototypeOf(Person));

// .prototyeOfLinkedObjects

Person.prototype.species = 'Homo Sapiens';
console.log(jonas.species, matilda.species);

console.log(jonas.hasOwnProperty('firstName'));
console.log(jonas.hasOwnProperty('species'));

console.log(jonas.__proto__.__proto__.__proto__);

console.dir(Person.prototype.constructor);

const arr = [1, 7, 3, 5, 5, 6, 7, 10, 5]; // -> this is the same as using new Array
console.log(arr.__proto__); // shows prototype of Array object (map, reduce, filter, indexOf)
// any array will inherit from its prototype
console.log(arr.__proto__ === Array.prototype);

// creating my own method to the prototype array constructor
Array.prototype.unique = function () {
  // method that returns an array with only unique elements
  return [...new Set(this)];
};

// now I can call the unique method on any array
console.log(arr.unique());
