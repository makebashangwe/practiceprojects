using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp2
{
    public class HumanStory
    {
        public static void TellStoryH(string name)
        {
            string userInput;
            int number;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write($"{name}, armed with only a basic staff and a flicker of magic within, embarks on a journey through the ancient **Whispering Woods.** The trees, adorned with luminescent moss, hold ancient secrets and elusive creatures.\r\n\rNavigate through encounters with mystical beings, learning to harness their elemental abilities and unraveling clues about the Veil.\r\n\r\nAs you step onto the magical soil of Elardia, the whispers of ancient prophecies greet you. Your presence here is no mere coincidence, {name}....");
            Console.Write("A man guides you through the dark cave, his torch flickering as shadows dance on the walls.");
            Console.Write("1. Ask about Your Arrival:\r\n    - “How did we get here?”\r\n2. Inquire about the Guide:\r\n    - “Who are you?”\r\n3. Remain Silent:\r\n    - …");
            Console.WriteLine("Enter a number:");
            PlayerResponse(userInput = Console.ReadLine());
            Console.WriteLine("The man halts, lifting the torch to reveal ancient inscriptions you can't decipher.\r\n\r\n1. Ask About the Location:\r\n    - “Where are we?”\r\n2. Question the Symbols:\r\n    - “What is this?”");
            Console.WriteLine("Enter a number:");
            PlayerResponse(userInput = Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"Man: This, {name}, is your destiny. You are here to save us all. I must provide you with the tools you need.");
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Press Enter to Continue...");
            }

            while (Console.ReadKey().Key != ConsoleKey.Enter); Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Man: Soon, the Veil approaches, casting shadows upon the harmonious magic of Cosmiia. Neptar, the god of prayer, is angered by our negligence. We've exploited the absence of her wrath, forgotten to pay homage, and the youth have abandoned tradition. (coughs sickly) I foresaw this years ago, but age has caught up with me. The Veil must be stopped, and I entrust this duty to you, young sorcerer. You are the chosen one…");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\r\n\r\nHe hands you a bag of silver.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Man: This is all I have - 200 silver. Take it to purchase the materials you'll need.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n1. Question Your Selection:\r\n    - “But why me?”\r\n2. Discover Your Portrayal:\r\n    - \"Look at the walls…\"");
            PlayerResponse(userInput = Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Your face is drawn across the cave walls, your name inscribed in a script different from the ancient language.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Man: In this time of turmoil, your destiny unfolds. {name} , the journey ahead is filled with choices, alliances, and challenges. Embrace your magical abilities, navigate societal dynamics, and forge a path that will restore balance or plunge the realms into chaos.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The cave begins to crumble.\r\n\r\n1. React to the Collapse:\r\n    - “What’s happening?”\r\n2. Urge Action:\r\n    - “We have to go!”");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Man: My time has come, {name}. Go, save Elardia!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("As the cave collapses, you find yourself standing alone in a clearing away from the ruins of the caves.");
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Press Enter to Continue...");
            }

            while (Console.ReadKey().Key != ConsoleKey.Enter);

        }
        private static void PlayerResponse(string userInput)
        {
            int number;

            if (int.TryParse(userInput, out number))
            {
                
            }
            else
            {
                Console.WriteLine("Please enter a number from 1-3: ");
                Console.WriteLine("Enter a number:");
                PlayerResponse(userInput = Console.ReadLine());
            }
        }
    }
}

