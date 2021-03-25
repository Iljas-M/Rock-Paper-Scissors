using System;

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
            Output.GameInfo();

            if (inputRoundCheck)
            {
                for (int i = 0; i < rounds; i++)
                {
                    Console.WriteLine("--------------------------------");
                    Console.Write("Select: ");
                    bool inputCheck = int.TryParse(Console.ReadLine(), out var userInput);

                    if (inputCheck && userInput < 3)
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
    }
}
