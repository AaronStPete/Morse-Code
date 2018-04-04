using System;
using System.Collections.Generic;
using System.IO;

namespace Morse_Code
{
    class Program
    {
        static void PrintMorseCodex(Dictionary<char, string> morseCodex)
        {
            Console.WriteLine("Printing the Morse Codex");
            Console.WriteLine("------------------------");
            foreach (var definition in morseCodex)
            {
                Console.WriteLine($"Key: {definition.Key} Value: {definition.Value}");
            }
        }

        static void ConvertToMorse(string input)
        {

        }

        static void Main(string[] args)
        {
            ///build dictionary
            var morseCodex = new Dictionary<char, string>();
            const string FILE_PATH = "../../../../morse.csv";
            using (var reader = new StreamReader(FILE_PATH))
            {
                while (reader.Peek() > -1)
                {
                    var line = reader.ReadLine().Split(',');
                    morseCodex.Add(Convert.ToChar(line[0]), line[1]);
                }
            }

            var isRunning = true;
            while (isRunning)
            {
                ///Prompt User for action
                Console.WriteLine("What would you like to do? (display) (translate) (stop)");
                var command = Console.ReadLine();
                if (command == "display")
                {
                    ///Display MorseCodex
                    PrintMorseCodex(morseCodex);
                }
                else if (command == "translate")
                {
                    ///Translate a phrase:

                    ///prompt user for accepted characters
                    Console.WriteLine("Enter the phrase you would like to translate. Acceptable characters include A-Z and 0-9.");

                    string input = Console.ReadLine().ToUpper();
                    Console.WriteLine($"Translating {input}.");

                    /// - compare to MorseCodex
                    var phrase = input.ToCharArray();
                    Console.WriteLine($"{phrase}");
                    var morseOutput = "";
                    Console.WriteLine($"{morseOutput}");
                    foreach (var poop in phrase)
                    {
                        if (morseCodex.ContainsKey(poop))
                        {
                            morseOutput = morseOutput + (morseCodex[poop].ToString());
                            Console.WriteLine($"{morseOutput}");
                        }
                        else
                        {
                            Console.WriteLine("Your phrase did not work, please try another phrase.");
                        }
                    }
                }
                else if (command == "stop")
                {
                    isRunning = false;
                }
                /// Offer to translate another string
            }
        }
    }
}
