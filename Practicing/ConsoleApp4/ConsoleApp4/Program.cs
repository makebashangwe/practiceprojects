using System;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;

namespace UsernamePasswordTest
{
        class Program
    {
        static void Main(string[] args)
        {
            string correctPassword = "";
            string enteredPassword;
            int guesses = 3;
            int minAttempts = 0;
            char at = '@';

            Console.Write("Welcome. Please enter your username: ");
            string name = Console.ReadLine();
            string username = at + name;
            Console.WriteLine("Your username is " + username);

            Console.WriteLine(username + ", please create a password: ");
            correctPassword = Console.ReadLine();
            Console.WriteLine("Hope you wrote it down. Let's login? (yes/no): ");
            string userInput = Console.ReadLine();
            bool continueLogin = userInput.ToLower() == "yes";

            if (continueLogin)
            {
                Console.Clear();
                string enteredUsername;

                Console.WriteLine("Enter your username: ");
                enteredUsername = Console.ReadLine();

                if (enteredUsername != name)
                {
                    Console.Clear();
                    Console.WriteLine(enteredUsername + " is not a username. Please enter a valid username.");
                }
                do
                {
                    Console.WriteLine("Enter your username: ");
                    enteredUsername = Console.ReadLine();
                    if (enteredUsername != name)
                    {
                        Console.Clear();
                        Console.WriteLine(enteredUsername + " is not a username. Please enter a valid username.");
                    }
                }
                while (enteredUsername != name);


                if (enteredUsername == name)
                {
                    do
                    {
                        Console.WriteLine("Password: ");
                        Console.WriteLine($"Guesses Remaining: " + guesses);
                        enteredPassword = Console.ReadLine();
                        if (enteredPassword != correctPassword)
                        {
                            guesses--;
                        }
                        if (guesses < minAttempts)
                        {
                            Console.WriteLine($"Exceeded maximum attempts. Access Denied.");
                            return;
                        }

                    }
                    while (correctPassword != enteredPassword);

                    Console.WriteLine("Correct Password! Access granted.");
                }

            }

            else
            {
                Console.WriteLine("Are you sure? ");
                string userInputsure = Console.ReadLine();
                while (0 < 1)
                {
                    Console.WriteLine("Are you sure? ");
                    Console.ReadLine();
                }
            }
        }
    }
}