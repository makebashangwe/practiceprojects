import random

class STARTGAME:

    def gamestart(self):
        random_integer = random.randint(1, 100)

        while True:
            try:
                userguess = int(input("Guess a number between 1 and 100: \n\n"))
                if userguess == random_integer:
                    print("You win!")
                    break
                elif userguess < random_integer:
                    print("Your guess is too low!")
                elif userguess > random_integer:
                    print("Your guess is too high!")
            except ValueError:
                print("Please enter a valid guess.")
