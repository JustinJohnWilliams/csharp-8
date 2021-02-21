using System;

namespace cshaprp_8
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger fileLogger = new FileLogger();
            ILogger consoleLogger = new ConsoleLogger();

            Console.WriteLine("-------------------------BEGIN PATTERN MATCHING-------------------------");
            var card = CardDescriber.Describe(CardValue.Eight, CardSuit.Hearts);
            Console.WriteLine(card);

            card = CardDescriber.Describe(CardValue.Joker, CardSuit.Unknown);
            Console.WriteLine(card);

            card = CardDescriber.Describe((CardValue)1234, (CardSuit)5678);
            Console.WriteLine(card);
            Console.WriteLine("-------------------------END PATTERN MATCHING-------------------------");

            consoleLogger.LogMessage("-------------------------BEGIN DEFAULT INTERFACE-------------------------");
            fileLogger.LogMessage("Test Message");
            consoleLogger.LogMessage("Test Message");
            fileLogger.LogException(new ArgumentException("ArgA cannot be null", "ArgA"));
            consoleLogger.LogException(new ArgumentException("ArgA cannot be null", "ArgA"));
            consoleLogger.LogMessage("-------------------------END DEFAULT INTERFACE-------------------------");
        }
    }
}
