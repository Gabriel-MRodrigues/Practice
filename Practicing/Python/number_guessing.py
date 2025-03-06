import random

top_of_range = input("Type a number: ")

if top_of_range.isdigit():
        top_of_range = int(top_of_range)
        if top_of_range <= 0:
            print("Please type a number greater than 0 next time!")
            quit()
else:
    print("Type a number next time!")
    quit()

random_number = random.randint(0, top_of_range)

guesses = 0
while True:
    guesses += 1
    user_input = input("Make a guess: ")
    if(user_input.isdigit()):
        user_input = int(user_input)
    else:
        print("Please type a number next time!")
        continue

    if user_input == random_number:
        print("You got it!")
        break
    elif user_input < random_number:
        print("Too low...")
    else: 
        print("Too high...")

print(f"You got in {guesses} tries!")