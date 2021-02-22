using System.Text;
using System.Linq;

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
}
