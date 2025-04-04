from cryptography.fernet import Fernet
import os


def write_key():
    key = Fernet.generate_key()
    if os.path.exists("key.key"):
        pass
    else:
        with open("key.key", "wb") as key_file:
            key_file.write(key)

write_key()

def load_key():
    file = open("key.key", "rb")
    key = file.read()
    file.close()
    return key

file = "password.txt"
key = load_key()
fer = Fernet(key)

def add():
    name = input("Account name: ")
    pwd = input("Password: ")

    with open(file, "a") as f:
        f.write(f"{name}|{fer.encrypt(pwd.encode()).decode()}\n")
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
                    print(f"User: {user} | Password: {fer.decrypt(passwd.encode()).decode()}")
    else:
        print("File does not exists...")

max_tries = 3
while True:
    master_password = input("What is the master password? ")
    tries = 0
    while master_password != 'gabriel' and tries < max_tries:
        tries += 1
        print(f'Invalid password. You have {max_tries - tries} attempts left...')
        master_password = input('What is the master password? ')
    if master_password == 'gabriel':
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
                continue
        break
    else:
        print("Failed to login after 3 attempts. Exiting...")
        break