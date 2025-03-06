import random

user_wins = 0
computer_wins = 0
options = ['rock', 'paper', 'scissors']

while True:
    print(f"Score: Computer({computer_wins}) || Player({user_wins})")
    user_input = input("Type Rock/Paper/Scissors or Q to quit: ").lower()
    if user_input == 'q':
        break
    if user_input not in options: 
        continue #it's gonna go back to the top of the while loop
    random_number = random.randrange(0, 2 + 1)
    # rock: 0 paper: 1 scissors: 2
    computer_pick = options[random_number]
    print("Computer picked:", computer_pick)
    if user_input == computer_pick:
        print('Tie') 
    else:
        print("Computer pick: " + computer_pick + " || " + "Player pick: " + user_input)
        if user_input == 'rock' and computer_pick == 'scissors':
            print('You won!')
            user_wins += 1
            continue
        elif user_input == 'paper' and computer_pick == 'rock':
            print('You won!')
            user_wins += 1
            continue
        elif user_input == 'scissors' and computer_pick == 'paper':
            print('You won!')
            user_wins += 1
            continue
        else:
            print('You lost!')
            computer_wins += 1
            continue
print("goodbye")