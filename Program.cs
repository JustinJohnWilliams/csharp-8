using System;

namespace cshaprp_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------BEGIN PATTERN MATCHING-------------------------");
            var card = CardDescriber.Describe(CardValue.Eight, CardSuit.Hearts);
            var cardSwitch = CardDescriber.DescribeWithSwitchExpression(CardValue.Eight, CardSuit.Hearts);
            Console.WriteLine(card);
            Console.WriteLine(cardSwitch);

            card = CardDescriber.Describe(CardValue.Joker, CardSuit.Unknown);
            cardSwitch = CardDescriber.DescribeWithSwitchExpression(CardValue.Joker, CardSuit.Unknown);
            Console.WriteLine(card);
            Console.WriteLine(cardSwitch);

            card = CardDescriber.Describe((CardValue)1234, (CardSuit)5678);
            cardSwitch = CardDescriber.DescribeWithSwitchExpression((CardValue)1234, (CardSuit)5678);
            Console.WriteLine(card);
            Console.WriteLine(cardSwitch);
            Console.WriteLine("-------------------------END PATTERN MATCHING-------------------------");
        }
    }
}
