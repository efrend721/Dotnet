using System;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class Program
    {
        static void Main()
        {
            
            // Variable to control whether the program should continue running
            bool continueProgram = true;

            do
            {
                // Prompt the user to enter a regular expression or use the default
                Console.Write("Enter a regular expression (or press ENTER to use the default): ");
                string? inputRegex = Console.ReadLine();

                // If the user presses ENTER without typing anything, use the default regex
                if (string.IsNullOrWhiteSpace(inputRegex))
                {
                    inputRegex = @"^[a-z]+$"; // Default regex checks for at least one lowercase letter
                }

                // Try to create a Regex object from the input
                Regex regex;
                try
                {
                    regex = new Regex(inputRegex);
                }
                catch (ArgumentException ex)
                {
                    // If the regular expression is invalid, display an error and restart the loop
                    Console.WriteLine("Invalid regular expression: {0}", ex.Message);
                    continue;
                }

                // Prompt the user to enter some input to test against the regex
                Console.Write("Enter some input: ");
                string? userInput = Console.ReadLine();

                // Ensure userInput is not null
                userInput ??= "";

                // Check if the input matches the regular expression
                bool isMatch = regex.IsMatch(input: userInput);

                // Display the result
                Console.WriteLine("{0} matches {1}? {2}", userInput, inputRegex, isMatch);

                // Ask the user whether to continue or exit
                Console.WriteLine("Press ESC to end or any other key to try again.");
                ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    continueProgram = false;
                }

            } while (continueProgram);
        }
    }
}
