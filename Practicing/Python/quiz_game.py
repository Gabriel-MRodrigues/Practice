print("Welcome to my computer quiz!")
playing = input('Do you want to play? ')

if playing.lower() != 'yes':
    quit()

print("Okay! Let's play!")

answer = input("What does CPU stands for? ")
if answer.lower() == "central processing unit":
    print('Correct!')
else:
    print('Incorrect...')