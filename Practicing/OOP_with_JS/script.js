'use strict';
// This file is dedicated to learn OOP in JavaScript.
// I followed along with Jonas from his Udemy course since he was the instructor of this class.
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
    return new Date().getFullYear() - this.birthYear;
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

// Static method and classes
// it doesn't need to instantiate to be called
// it is not available on the instances

// Static methods belong to the class itself, not to instances of the class.
// You don't need to create an object to call them
// And instances can't access static methods directly

class MathUtils {
  static add(a, b) {
    return a + b;
  }

  subtract(a, b) {
    return a - b;
  }
}

console.log(MathUtils.add(3, 5)); // 8

const util = new MathUtils();
// console.log(util.add(5, 5)); it will give and error: util.add is not a function
console.log(util.subtract(9, 4)); // 5

// Object.create()
const PersonProto = {
  calcAge() {
    console.log(new Date().getFullYear() - this.birthYear);
  },

  init(firstName, birthYear) {
    this.firstName = firstName;
    this.birthYear = birthYear;
  },
};

const steven = Object.create(PersonProto); // defining which prototype steven object should look for
steven.name = 'Steve';
steven.birthYear = 2001;
steven.calcAge();

console.log(steven.__proto__ === PersonProto);

const wilma = Object.create(PersonProto);
wilma.init('Wilma', 1972);
wilma.calcAge();
console.log(wilma);

// Inheritance between classes - Constructor Function
const PersonI = function (firstName, birthYear) {
  this.firstName = firstName;
  this.birthYear = birthYear;
};

PersonI.prototype.calcAge = function () {
  console.log(new Date().getFullYear() - this.birthYear);
};

const Student = function (firstName, birthYear, course) {
  PersonI.call(this, firstName, birthYear);
  this.course = course;
};

// Linking prototypes (chaining prototypes)
Student.prototype = Object.create(PersonI.prototype);
// Now any student object will have access to functions on the Person class
// because they are linked
// Now, javascript will go through the chain searching for methods that are not in the student class

Student.prototype.introduce = function () {
  console.log(`My name is ${this.firstName} and I study ${this.course}`);
};

const khoi = new Student('Khoi', 2005, 'Computer Science');
khoi.introduce();
khoi.calcAge(); // it will look up to the prototype chain to find calcAge on the PersonI prototype

console.log(khoi instanceof Student); // true
console.log(khoi instanceof PersonI); // true
console.log(khoi instanceof Object); // true

// the constructor is still person
Student.prototype.constructor = Student; // here we change the constructor
console.dir(Student.prototype.constructor);

// Inheritance between classes using Class constructor
class StudentCl extends PersonCl {
  constructor(fullName, birthYear, course) {
    // it always needs to happen first ( the super keyword )
    super(fullName, birthYear);
    this.course = course;
  }

  introduce() {
    console.log(`${this.fullName} | ${this.calcAge()} | ${this.course}`);
  }
}

const ralph = new StudentCl('Ralph Goat', 2005, 'Business');
ralph.introduce();

// way easier to implement inheritance with the class constructor...

// Inheritance with Object.create()

// this is basically chaining the prototypes

const StudentProto = Object.create(PersonProto);
StudentProto.init = function (firstName, birthYear, course) {
  PersonProto.init.call(this, firstName, birthYear);
  this.course = course;
};

const jay = Object.create(StudentProto);
jay.init('Jay', 2010, 'IDK');
jay.calcAge();

// Encapsulation: Private Class Fields and Methods

// 1. Public fields
// 2. Private fields
// 3. Public methods
// 3. Private methods

class Account {
  locale = navigator.language;
  bank = 'Gabriel Bank';
  #movements = [];
  #pin;

  constructor(owner, currency, pin) {
    this.owner = owner;
    this.currency = currency;
    this.#pin = pin;
    // this.movements = [];
    // this.locale = navigator.language;

    console.log('Thanks for opening an account with us!');
  }

  // Public interfaces (API)
  deposit(val) {
    this.#movements.push(val);
    // adding the return this to the method
    // will give the possibility to chain methods of the object
    return this;
  }

  withdraw(val) {
    this.deposit(-val);
    return this;
  }

  #approveLoan(val) {
    return true;
  }

  requestLoan(val) {
    if (this.#approveLoan(val)) {
      this.deposit(val);
      return this;
    }
  }

  get balance() {
    return this.#movements.reduce((acc, mov) => acc + mov, 0);
  }

  getMovements() {
    console.log(this.#movements);
    return this.#movements;
  }

  getPin() {
    return this.#pin;
  }
}

const gabrielAccount = new Account('Gabriel', 'CAD', 1234);
console.log(gabrielAccount);

// adding movements
gabrielAccount.deposit(500);
gabrielAccount.withdraw(250);
gabrielAccount.requestLoan(200);

// console.log(gabrielAccount.#movements); -> not accessible
// console.log(gabrielAccount.#approveLoan); -> not accessible

console.log(gabrielAccount);
console.log(gabrielAccount.balance);
gabrielAccount.getMovements();
console.log(gabrielAccount.getPin());

// chaining methods.
// to call each method we should call it from the class
// that is why on each method we return the object ( this )
// so it will be able to call another method from it again
gabrielAccount
  .deposit(300)
  .withdraw(100)
  .withdraw(10)
  .requestLoan(25000)
  .withdraw(4000)
  .getMovements();

// class summary with one more example
class StudentSummary extends Person {
  college = 'NBCC';
  #studyHours = 0;
  #course;
  static numSubjects = 10;

  constructor(fullName, birthYear, startYear, course) {
    super(fullName, birthYear);
    this.startYear = startYear;
    this.#course = course;
  }

  introduce() {
    console.log(`I study ${this.#course} at ${this.college}`);
  }

  study(h) {
    this.#makeCoffee();
    this.#studyHours += h;
  }

  #makeCoffee() {
    return 'Coffee for you!';
  }

  get testScore() {
    return this._testScore;
  }

  set testScore(score) {
    this._testScore = score < 20 ? score : 0;
  }

  static printCurriculum() {
    console.log(`There are ${this.numSubjects} subject`);
  }
}

const student = new StudentSummary('Gabriel Rodrigues', 2005, 2024, 'ITSD');
