using System.Text;
using System.Linq;
using System;

public static class CardDescriber
{
    public static string Describe(Card card)
    {
        return Describe(card.Value, card.Suit);
    }

    public static string Describe(CardValue value, CardSuit suit)
    {
        var sb = new StringBuilder();

        sb.Append(Describe(value));
        sb.Append(" of ");
        sb.Append(Describe(suit));

        return sb.ToString();
    }

    private static string Describe(CardValue value) =>
        value switch
        {
            var name when name == CardValue.Ace || Game.FaceCards.Contains(name)
                            => value.FirstToUpper(),
            CardValue.Two   => "2",
            CardValue.Three => "3",
            CardValue.Four  => "4",
            CardValue.Five  => "5",
            CardValue.Six   => "6",
            CardValue.Seven => "7",
            CardValue.Eight => "8",
            CardValue.Nine  => "9",
            CardValue.Ten   => "10",
            _               => "?"
        };

    private static string Describe(CardSuit suit) =>
        suit switch
        {
            var name when (name == CardSuit.Clubs
                        || name == CardSuit.Diamonds
                        || name == CardSuit.Hearts
                        || name == CardSuit.Spades)
                            => suit.ToString().ToUpper(),
            _               => "??"
        };

    public static int CalculateValue(Card card) =>
        card switch
        {
            { Value: CardValue.Ace }    => 1,
            { Value: CardValue.Two }    => 2,
            { Value: CardValue.Three }  => 3,
            { Value: CardValue.Four }   => 4,
            { Value: CardValue.Five }   => 5,
            { Value: CardValue.Six }    => 6,
            { Value: CardValue.Seven }  => 7,
            { Value: CardValue.Eight }  => 8,
            { Value: CardValue.Nine }   => 9,
            { Value: CardValue.Ten }    => 10,
            { Value: CardValue.Jack }   => 11,
            { Value: CardValue.Queen }  => 12,
            { Value: CardValue.King }   => 13,
            _                           => throw new ArgumentOutOfRangeException(
                                            message: "card value is unknown",
                                            paramName: nameof(card.Value))
        };
}
