using System;
using System.Collections.Generic;
using System.IO;

namespace Morse_Code
{
    class Program
    {
        static void PrintMorseCodex(Dictionary<string, string> morseCodex)
        {
            Console.WriteLine("Printing the Morse Codex");
            Console.WriteLine("------------------------");
            foreach (var definition in morseCodex)
            {
                Console.WriteLine($"Key: {definition.Key} Value: {definition.Value}");
            }
        }

        static void Main(string[] args)
        {
            var morseCodex = new Dictionary<string, string>();
            const string FILE_PATH = "../../../../morse.csv";
            using (var reader = new StreamReader(FILE_PATH))
            {
                while (reader.Peek() > -1)
                {
                    var line = reader.ReadLine().Split(',');
                    morseCodex.Add(line[0], line[1]);
                }
            }

            var isRunning = true;
            while (isRunning)
            {
                ///Prompt User for action
                Console.WriteLine("What would you like to do? (display)");
                var command = Console.ReadLine();
                if (command == "display")
                {
                    ///Display MorseCodex
                    PrintMorseCodex(morseCodex);
                }
                ///prompt user for accepted characters
                /// - let string input = Console.ReadLine()
                ///Translate a phrase
                /// - compare to MorseCodex
                /// - store as output
                ///Display converted text
                /// - display output as string
                /// Offer to translate another string
            }
        }
    }
}
