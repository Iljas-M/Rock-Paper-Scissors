using System;

namespace Rock_Paper_Scissors
{
    /// <summary>
    /// The Console output is only used to for creating Output.
    /// </summary>
    public static class Output
    {
        /// <summary>
        /// Output the selection.
        /// </summary>
        public static void GameInfo()
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
