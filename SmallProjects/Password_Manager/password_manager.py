from cryptography.fernet import Fernet
import os


file = "password.txt"
master_password = input("What is the master password? ")

def add():
    name = input("Account name: ")
    pwd = input("Password: ")

    with open(file, "a") as f:
        f.write(f"{name}|{pwd}\n")
    print("Adding password...")

def view():
    if os.path.exists(file):
        with open(file, "r") as f:
            if(f.read() == ""):
                print("Nothing to show...")
            else:
                f.seek(0)
                for line in f.readlines():
                    data = line.rstrip()
                    user, passwd = data.split("|")
                    print(f"User: {user} | Password: {passwd}")
    else:
        print("File does not exists...")

while True:
    mode = input("Would you like to add (add) a new password or view (view) your passwords? Type q to quit. ").lower()
    if mode == 'q':
        print("Good bye!")
        break

    if mode == 'add':
        add()
    elif mode == 'view':
        view()
    else:
        print("Invalid option...")
        continue;