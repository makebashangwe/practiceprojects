from main import Calculator

calculator1 = Calculator()

while True:
    try:
        num1 = float(input("Enter a number: "))
        op = input("Choose an operation: +, -, *, /\n")
        while op not in ["+", "-", "*", "/"]:
            op = input("Please input a valid operation: ")
        num2 = float(input("Enter a second number: "))

        calculator1.start_calculator(num1, op, num2)

        play_again = input("Would you like to use the calculator again? (Y/N)").upper()
        if play_again not in ["Y", "N", "YES", "NO"]:
            print("Please enter Y or N.")
        elif play_again == "N" or play_again == "NO":
            break
    except ValueError:
        print("Error, please enter valid numbers and operations.")
