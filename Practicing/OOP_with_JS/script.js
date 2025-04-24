'use strict';
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
  console.log(new Date().getFullYear() - this.birthYear);
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

// class expression
// const PersonCl = class {}

// class declaration
class PersonCl {
  constructor(fullName, birthYear) {
    this.fullName = fullName;
    this.birthYear = birthYear;
  }

  // this function will be automatically added to the prototype property of the PersonCl class
  calcAge() {
    console.log(new Date().getFullYear() - this.birthYear);
  }

  get age() {
    return new Date().getFullYear() - this.birthYear;
  }

  set fullName(name) {
    console.log(name);
    if (name.includes(' ')) {
      this._fullName = name;
    } else {
      console.log(`${name} is not a fullName`);
    }
  }

  get fullName() {
    return this._fullName;
  }
}

const gabriel = new PersonCl('Gabriel Rodrigues', 2005); // will give the set error of "name is not a fullName" if Name doesn't have space
console.log(gabriel);
gabriel.calcAge();

console.log(gabriel.__proto__ === PersonCl.prototype);

// it works exactly the same as creating the function inside the class
PersonCl.prototype.greet = function () {
  console.log(`Hey ${this.firstName}`);
};

gabriel.greet();

// 1. Classes are NOT hoisted
// 2. Classes are also first-class citizens ( we can pass them into functions and return them from functions )
// 3. Classes are executed in strict mode

// function constructors look a bit messy...
// while using classes constructors the code looks more cleaner and organized
// because the properties and the behaviors will be inside the class constructor

// Getters and Setters
const account = {
  owner: 'Gabriel',
  movements: [200, 300, 500, 340, 540],

  get latest() {
    return this.movements.slice(-1).pop();
  },

  set latest(mov) {
    // it must have exactly one parameter
    this.movements.push(mov);
  },
};

// we call it as a property
console.log(account.latest); // 540
account.latest = 50; // setting latest element to 50
console.log(account.movements);
console.log(account.latest); // 50

// adding age getter on PersonCl class
console.log(gabriel.age); // access it as a property

console.log(gabriel.fullName); // fullname is not defined
// if full name doesn't respect the setter function the fullname property will not be created and it will be UNDEFINED
