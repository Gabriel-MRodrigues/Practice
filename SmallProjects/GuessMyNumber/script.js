'use strict';

let secretNumber = Math.trunc(Math.random() * 20) + 1;
let score = 20;
const scoreMessage = document.querySelector('.score');
let highScore = 0;
const highScoreMessage = document.querySelector('.highscore');

const displayMessage = function (message) {
  document.querySelector('.message').textContent = message;
};

document.querySelector('.check').addEventListener('click', () => {
  const guess = Number(document.querySelector('.guess').value);

  if (!guess) {
    displayMessage('No number.');
  } else if (guess < 1 || guess > 20) {
    displayMessage('Out of Range... try between 1 and 20');
  } else if (guess !== secretNumber) {
    if (score > 1) {
      displayMessage(guess > secretNumber ? 'Too high...' : 'Too low...');
      score--;
      scoreMessage.textContent = score;
    } else {
      displayMessage('You lost the game.');
      scoreMessage.textContent = 0;
    }
  } else if (guess === secretNumber) {
    if (highScore < score) {
      highScore = score;
      highScoreMessage.textContent = highScore;
    }
    displayMessage('Correct Number!');
    document.querySelector('.number').textContent = secretNumber;
    document.querySelector('body').style.backgroundColor = '#60b347';
    document.querySelector('.number').style.width = '30rem';
  }
});

document.querySelector('.again').addEventListener('click', () => {
  document.querySelector('body').style.backgroundColor = '#222';
  displayMessage('Start guessing...');
  secretNumber = Math.trunc(Math.random() * 20) + 1;
  score = 20;
  scoreMessage.textContent = score;
  document.querySelector('.number').style.width = '15rem';
  document.querySelector('.number').textContent = '?';
  secretNumber = Math.trunc(Math.random() * 20) + 1;
  document.querySelector('.guess').value = '';
});
