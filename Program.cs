using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace cshaprp_8
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger consoleLogger = new ConsoleLogger();

            consoleLogger.LogMessage($"Player 1 has {Game.Player1.Hand.Count}");
            consoleLogger.LogMessage($"Player 2 has {Game.Player2.Hand.Count}");

            while(Game.Player1.Hand.Any())
            {
                consoleLogger.LogMessage($"Player 1 Draws {Game.Player1.Draw()}");
                consoleLogger.LogMessage($"Player 2 Draws {Game.Player2.Draw()}");
            }

            Console.ReadLine();

            consoleLogger.LogMessage($"Attempting a new draw....");
            consoleLogger.LogMessage($"Player 1 Draws {Game.Player1.Draw()}");

            consoleLogger.LogMessage($"Player 1 has {Game.Player1.Hand.Count}");
            consoleLogger.LogMessage($"Player 2 has {Game.Player2.Hand.Count}");
        }
    }
}
