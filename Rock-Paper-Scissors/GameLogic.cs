using System;
using System.Collections.Generic;

namespace Rock_Paper_Scissors
{
    /// <summary>
    /// The Game Logic Class.
    /// </summary>
    public class GameLogic
    {
        /// <summary>
        /// Gets or sets the counter wins.
        /// </summary>
        /// <value> The counter wins. </value>
        public int CounterWins { get; set; }

        /// <summary>
        /// The picked number list.
        /// </summary>
        private List<int> pickedNumberList = new List<int>();

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value> The option type.</value>
        private DifferentOptionTypes Type { get; set; }

        /// <summary>
        /// Calculations the specified user input.
        /// </summary>
        /// <param name="userInput">The user input.</param>
        /// <returns>Winner or Loser.</returns>
        public string Calculation(DifferentOptionTypes userInput)
        {
            var pcInput = this.ComputerChoice();
            Console.WriteLine($"Computer : '{pcInput}' | You: '{userInput}'");

            // Bestimmt kann man das viel leichter und schöner gestalten.
            // Scheren Check.
            if (pcInput == DifferentOptionTypes.Schere && userInput == DifferentOptionTypes.Papier)
            {
                return "You lost!";
            }
            else if (pcInput == DifferentOptionTypes.Schere && userInput == DifferentOptionTypes.Stein)
            {
                this.CounterWins++;
                return "You won!";
            }

            // Papier Check.
            if (pcInput == DifferentOptionTypes.Papier && userInput == DifferentOptionTypes.Schere)
            {
                this.CounterWins++;
                return "You won!";
            }
            else if (pcInput == DifferentOptionTypes.Papier && userInput == DifferentOptionTypes.Stein)
            {
                return "You lost!";
            }

            // Stein Check.
            if (pcInput == DifferentOptionTypes.Stein && userInput == DifferentOptionTypes.Papier)
            {
                this.CounterWins++;
                return "You won!";
            }
            else if (pcInput == DifferentOptionTypes.Stein && userInput == DifferentOptionTypes.Schere)
            {
                return "You lost!";
            }

            return "Draw";
        }

        /// <summary>
        /// The computer chooses a number.
        /// </summary>
        /// <returns>Result of Computer.</returns>
        private DifferentOptionTypes ComputerChoice()
        {
            // Generate random Number with the help of cryptography.
            // https://docs.microsoft.com/de-de/dotnet/api/system.security.cryptography.randomnumbergenerator?view=net-5.0
            var randomNumber = System.Security.Cryptography.RandomNumberGenerator.GetInt32(0, 3);

            // Add the generated number into List.
            this.pickedNumberList.Add(randomNumber);

            int tempNumber = 0;

            // Generate a new number only after two existing numbers.
            if (this.pickedNumberList.Count > 2)
            {
                // The same number can only be used.
                tempNumber = this.pickedNumberList[2];
                this.pickedNumberList.Clear();

                // if the third number is the same as the last, then generate a new one again.
                do
                {
                    randomNumber = System.Security.Cryptography.RandomNumberGenerator.GetInt32(0, 3);
                }
                while (tempNumber == randomNumber);
            }

            // Go through the enum and output the selected type.
            foreach (int type in Enum.GetValues(typeof(DifferentOptionTypes)))
            {
                if (type == randomNumber)
                {
                    this.Type = (DifferentOptionTypes)type;
                    break;
                }
            }

            return this.Type;
        }
    }
}
