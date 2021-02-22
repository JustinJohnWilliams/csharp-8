using System;

namespace cshaprp_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------BEGIN PATTERN MATCHING-------------------------");
            var card = CardDescriber.Describe(CardValue.Eight, CardSuit.Hearts);
            Console.WriteLine(card);

            card = CardDescriber.Describe(CardValue.Joker, CardSuit.Unknown);
            Console.WriteLine(card);

            card = CardDescriber.Describe((CardValue)1234, (CardSuit)5678);
            Console.WriteLine(card);
            Console.WriteLine("-------------------------END PATTERN MATCHING-------------------------");
        }
    }
}
