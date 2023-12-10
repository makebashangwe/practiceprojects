using System;
using System.ComponentModel.DataAnnotations;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] movies = new string[4];

            Console.WriteLine("Enter 4 movies: ");


            for (int i = 0; i < movies.Length; i++)
            {
                movies[i] = Console.ReadLine();
               
            }

                Array.Sort(movies);
                for (int i = 0; i < movies.Length; i++)
                {
                    Console.WriteLine(movies[i]);
                }

            
        }
    }
}