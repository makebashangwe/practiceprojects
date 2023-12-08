class Calculator:
    def start_calculator(self, num1, op, num2):
        while True:
            if op == "+":
                result = num1 + num2
                print(result)
                break
            elif op == "-":
                result = num1 - num2
                print(result)
                break
            elif op == "*":
                result = num1 * num2
                print(result)
                break
            elif op == "/":
                if num2 == 0:
                    print("UNDEFINED.")
                else:
                    result = num1 / num2
                    print(result)
                    break
            else:
                print("Could not calculate.")
                break


