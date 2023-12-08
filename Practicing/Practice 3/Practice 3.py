from start_game import STARTGAME

print("HEY HEY HEY!\nWelcome to guess the number!")

game_instance = STARTGAME()
game_instance.gamestart()

while True:
    try:
        playAgain = input("Play Again? (Y/N) \n\n").lower()
        if playAgain == "n" or playAgain == "no":
            print("Goodbye.")
            exit()
        elif playAgain == "":
            print("Please enter a valid response.\n\n")
        else:
            game_instance.gamestart()

    except ValueError:
        print("Error. Please enter Y or N.")
