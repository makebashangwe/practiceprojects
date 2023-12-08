from Question import Human
import os
def clear_screen():
    if os.name == 'nt':
        os.system('cls')  # For Windows
    elif 'TERM' in os.environ and os.environ['TERM'] == 'xterm':
        os.system('clear')  # For Unix-like systems with 'xterm' as the TERM
    else:
        print("Unable to clear console. Unsupported environment.")

human1 = Human()
name = input("What is your name?\n\nName: ").capitalize()
food = input("What's your favorite food?\n\n Food: ")

while True:
    try:
        userChoice = input(name + ", what would you like to do?\n(A) Eat\n(B) Sleep\n(C) Kill\n\n")

        if userChoice.upper() == "A":
            human1.eat_food(name, food)
            break
        elif userChoice.upper() == "B":
            human1.sleep(name)
            break
        elif userChoice.upper() == "C":
            human1.kill_people(name)
            break
        else:
            print("Invalid choice.")
            clear_screen()

    except Exception as e:
        print("Error:", e)
        print("Please enter A, B, or C")
        clear_screen()
