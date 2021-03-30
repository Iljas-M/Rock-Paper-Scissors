using System;
using System.Linq;

namespace Rock_Paper_Scissors
{
    /// <summary>
    /// The Program Class.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        private static void Main(string[] args)
        {
            // Create new Game.
            var newGame = new GameLogic();

            Console.Write("Please write how many rounds you would like to play: ");
            bool inputRoundCheck = int.TryParse(Console.ReadLine(), out var rounds);
            GameInfo();

            if (inputRoundCheck)
            {
                for (int i = 0; i < rounds; i++)
                {
                    Console.WriteLine("--------------------------------");
                    Console.Write("Select: ");

                    string input = Console.ReadLine();
                    bool inputCheck = int.TryParse(input, out var userInput);

                    if (inputCheck && Enumerable.Range(0, 3).Contains(userInput) && input.ToString().Length == 1)
                    {
                        var result = newGame.Calculation((DifferentOptionTypes)userInput);
                        Console.WriteLine($"Result: {result}");
                    }
                    else
                    {
                        Console.WriteLine($"You input '{userInput}' was incorrect");
                    }
                }

                // End.
                Console.WriteLine($"\r\nYou have won '{newGame.CounterWins}' out of '{rounds}' games!");
                Console.WriteLine($"\r\nHAPPY CODING :)");
            }
        }

        /// <summary>
        /// Output the selection.
        /// </summary>
        private static void GameInfo()
        {
            Console.WriteLine("\r\n************************************************************");
            Console.Write("\r\n\t Welcome to the Rock-Paper-Scissors Game!\r\n");
            Console.Write("\r\nPlease select: \r\n");
            Console.Write("\r\n\t [0] for Scissor\r\n");
            Console.Write("\t [1] for Rock\r\n");
            Console.Write("\t [2] for Paper\r\n");
            Console.WriteLine("\r\n************************************************************\r\n");
        }
    }
}
