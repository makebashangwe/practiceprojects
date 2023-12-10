using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Player(string Name, int coins, int MP, int health, int Level)
    {

        public string Name;
        public int coins = 0;
        public int health = 0;
        public int MP = 0;
        public int Level = 1;


        public void GetDescription()
        {
            Console.WriteLine($"STATS: \nName: {Name}\n coins: {coins}\n HP: {health} \n MP:{MP} \n LVL: {Level}");
        }
    }    
}
