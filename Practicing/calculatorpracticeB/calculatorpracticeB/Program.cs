using System;
namespace RockPaperStrippers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome. Please choose Rock,Paper, or Scissors: ");
            string userInput = Console.ReadLine().ToUpper();
            Random random = new random(1,4);
            int computer;

            
            switch (userInput)
            {
                case 1:
                    {
                        Console.WriteLine("You Lose");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("You Win");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("It's a tie!");
                        break;
                    }


            }    
        }
    }
}