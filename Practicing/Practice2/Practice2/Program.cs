using System;
using System.ComponentModel.Design;
using System.Text;

namespace RockPaperScissorsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";

                while (player != "ROCK" & player != "PAPER" & player != "SCISSORS")
                {
                    Console.Write("ENTER ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();

                    Console.WriteLine("Player: " + player);
                }
            
                
                switch (random.Next(1, 4))
                {
                     case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("Computer: " + computer);


                switch (player)
                {
                    case "ROCK":
                       if (computer == "ROCK") 
                        {
                            Console.WriteLine("It's a draw");
                        }
                        else if (computer == "PAPER") 
                        {
                            Console.WriteLine("You Lose!");
                        }
                        else
                        {
                            Console.WriteLine("You won!");
                        }
                        break;
                    case "PAPER":
                     if (computer == "ROCK") 
                        {
                            Console.WriteLine("You Won!");
                        }
                        else if (computer == "PAPER") 
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else 
                        {
                            Console.WriteLine("You lost!");
                        }
                        break;

                    case "SCISSORS":
                         if (computer == "ROCK") 
                        {
                            Console.WriteLine("You Lost!");
                        }
                        else if (computer == "PAPER") 
                        {
                            Console.WriteLine("You Won!!");
                        }
                        else 
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        break;
                    }
                Console.Write("Would you like to play again (Y/N)");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                    Console.Write("Bye, Loser >:)");

                }

                }
            }
        }
    }
