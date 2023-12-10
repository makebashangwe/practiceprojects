using ConsoleApp2;
using System;

namespace LegendsOfCosmiia
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        public static void Start()
        {

            string Name;
            string userInput;
            int userChoice;
            bool selectQuest;
            int number;

            do
            {
                Console.WriteLine("Welcome to Legends of Cosmiia: Shadows & Balance. What is your name, mighty hero?");
                Name = Console.ReadLine();


                Console.Write($"{Name}, get ready to begin your journey. Below are descriptions of the paths available. Choose wisely young hero...");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n1. Human Sorcerer: \nEmbrace the Arcane Path:\nChoose to walk the mystical path of the Human Sorcerer, where your magical prowess stems from the ancient art of conjuring spells and wielding enchanted weapons obtained from the mystical realms of high elves, drows, and fairies. Your strength reaches its zenith when armed, as the bond between you and your weapon magnifies your magical capabilities, making you a formidable force on the battlefield.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n2. High Elf: \nHarmony in Magic:\nStep into the world of the High Elf, where the delicate equilibrium of magical forces defines your existence. Born with an 80/20 random distribution favoring a balanced nature, most high elves are harmoniously attuned to magic, making them the preferred kin in mystical realms. However, the fate of unbalanced high elves takes a different turn, oppressed due to the misguided belief that they are weaker.\nAs a High Elf, you may find refuge or acceptance among the drows, a choice that can lead to dire consequences. Your destiny is shaped by this intricate dance of balance and prejudice, where your magical prowess becomes a testament to the struggle for equality and the unlocking of your true potential.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n3. Drow: \nHarness the Shadows:\nEnter the world of the Drow, the most potent among elves, bearing the heavy burden of oppression despite your extraordinary magical abilities. Born unbalanced and endowed with the potential to enhance your formidable magic skills, you navigate a world where societal injustice casts a shadow over your true potential.\nEndure the prejudice that separates you from your kin, and let your magical prowess, honed through acquired skills, set you apart. The struggle against oppression is woven into your story, driving you to unlock the full extent of your inherent magical might. Embrace the power within the shadows and become a powerful, yet misunderstood, force in the realms.");
                Console.WriteLine("Input a number to select a race: ");
                userInput = Console.ReadLine();

                if (int.TryParse(userInput, out number))
                {
                    if (number > 3)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a number less than or equal to 3");
                        DisplayCharacterOptions(userInput = Console.ReadLine());

                    }
                    else if (number <= 3)
                    {
                        switch (number)
                        {
                            case 1:
                                Console.WriteLine($"The mystical energies of Elardia respond to your presence, {Name}. As a Human Sorcerer, your journey is one of conjuring spells and wielding enchanted weapons. The delicate balance of magic awaits your touch.\nAre you ready to embark on this path, {Name}?\r\n\r\n[YES/NO]: ");
                                string beginQuest = Console.ReadLine().ToUpper();
                                if (beginQuest == "Y" || beginQuest == "YES")
                                {
                                    selectQuest = true;
                                    HumanStory.TellStoryH(Name);
                                }
                                else if (beginQuest == "N" || beginQuest == "NO")
                                {
                                    Console.Clear();
                                    Start();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("There was an error, please try again.");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    DisplayCharacterOptions(userInput = Console.ReadLine());

                                    if (beginQuest == "Y" || beginQuest == "YES")
                                    {
                                        selectQuest = true;
                                        HumanStory.TellStoryH(Name);
                                    }
                                }
                                break;
                        }
                    }
                }

            }
            while (selectQuest = false);

        }
        private static void DisplayCharacterOptions(string userInput)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n1. Human Sorcerer: \nEmbrace the Arcane Path:\nChoose to walk the mystical path of the Human Sorcerer, where your magical prowess stems from the ancient art of conjuring spells and wielding enchanted weapons obtained from the mystical realms of high elves, drows, and fairies. Your strength reaches its zenith when armed, as the bond between you and your weapon magnifies your magical capabilities, making you a formidable force on the battlefield.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n2. High Elf: \nHarmony in Magic:\nStep into the world of the High Elf, where the delicate equilibrium of magical forces defines your existence. Born with an 80/20 random distribution favoring a balanced nature, most high elves are harmoniously attuned to magic, making them the preferred kin in mystical realms. However, the fate of unbalanced high elves takes a different turn, oppressed due to the misguided belief that they are weaker.\nAs a High Elf, you may find refuge or acceptance among the drows, a choice that can lead to dire consequences. Your destiny is shaped by this intricate dance of balance and prejudice, where your magical prowess becomes a testament to the struggle for equality and the unlocking of your true potential.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n3. Drow: \nHarness the Shadows:\nEnter the world of the Drow, the most potent among elves, bearing the heavy burden of oppression despite your extraordinary magical abilities. Born unbalanced and endowed with the potential to enhance your formidable magic skills, you navigate a world where societal injustice casts a shadow over your true potential.\nEndure the prejudice that separates you from your kin, and let your magical prowess, honed through acquired skills, set you apart. The struggle against oppression is woven into your story, driving you to unlock the full extent of your inherent magical might. Embrace the power within the shadows and become a powerful, yet misunderstood, force in the realms.");
            Console.WriteLine("Input a number to select a race: ");
            userInput = Console.ReadLine();


        }
    }

}
        
  