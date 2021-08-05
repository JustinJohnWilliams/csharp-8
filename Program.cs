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

            while(Game.IsNotOver())
            {
                var cards = Game.PlayRound();
                consoleLogger.LogMessage($"{Game.Player1.Name} plays {cards.Player1Card}");
                consoleLogger.LogMessage($"{Game.Player2.Name} plays {cards.Player2Card}");
                Game.EvaluateRound(cards);
            }

            Console.ReadLine();

            consoleLogger.LogMessage($"Attempting a new draw....");
            consoleLogger.LogMessage($"Player 1 Plays {Game.Player1.PlayCard()}");

            consoleLogger.LogMessage($"Player 1 has {Game.Player1.Hand.Count}");
            consoleLogger.LogMessage($"Player 2 has {Game.Player2.Hand.Count}");
        }
    }
}
