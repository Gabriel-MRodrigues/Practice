name = input("What is your name?")
print(f"Welcome {name} to this adventure")
answer = input("You are on a dirty road, it has come to an end and you can go left or right. Choose your path: right or left ").lower()
if answer == 'left':
    answer = input("You come to a river, you can walk around or swim. Type walk to walk around or swim to go through the river ").lower()
    if answer == 'swim':
        print('You swam across and and were eaten by an alligator.')
    elif answer == 'walk':
        print('You walked for miles and ran out of water and die.')
    else:
        print("Invalid option. You lose.")
elif answer == 'right':
    answer = input("You came to a bridge, it look wobbly, do you want to go back (back) or risk your life (risk)?").lower()
    if answer == 'back':
        print("You go back and lose.")
    elif answer == 'risk':
        answer = input('You crossed the bridge and meet and strange. Do you talk to him? (Yes or No)').lower()
        if answer == 'yes':
            print('You talked to stranger and he gave you gold. You won!')
        elif answer == 'no':
            print('He killed you because you did not talked to him')
        else:
            print("Invalid option. You lose")
    else:
        print('Invalid option. You lose.')
else:
    print("Invalid option. You lose.")
print(f"Thank you for trying {name}... see you!")