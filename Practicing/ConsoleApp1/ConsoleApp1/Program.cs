using System;

namespace PrimeorNawl
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string userInput;

            Console.Write("Enter a integer : ");
            n = int.Parse(Console.ReadLine());
            bool isPrime = IsPrime(n);

            if (isPrime)
            {
                Console.WriteLine($"{n} is a prime number!");
            }
            else
            {
                Console.WriteLine($"{n} is not a prime number...");
            }

            static bool IsPrime (int num)
            {
                if (num < 2)
                    return false;
                for (int i= 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                        return false;
                }
                return true;
                
            }
        }
    }
}