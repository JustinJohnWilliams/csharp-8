using System.Text;

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

    private static string Describe(CardValue value)
    {
        var result = "";

        switch(value)
        {
            case CardValue.Ace:
            case CardValue.Jack:
            case CardValue.Queen:
            case CardValue.King:
                result = value.FirstToUpper();
                break;
            case CardValue.Two:
                result = "2";
                break;
            case CardValue.Three:
                result = "3";
                break;
            case CardValue.Four:
                result = "4";
                break;
            case CardValue.Five:
                result = "5";
                break;
            case CardValue.Six:
                result = "6";
                break;
            case CardValue.Seven:
                result = "7";
                break;
            case CardValue.Eight:
                result = "8";
                break;
            case CardValue.Nine:
                result = "9";
                break;
            case CardValue.Ten:
                result = "10";
                break;
            default:
                result = "?";
                break;
        }

        return result;
    }

    private static string Describe(CardSuit suit)
    {
        var result = "";

        switch(suit)
        {
            case CardSuit.Clubs:
            case CardSuit.Diamonds:
            case CardSuit.Hearts:
            case CardSuit.Spades:
                result = suit.ToString().ToUpper();
                break;
            default:
                result = "??";
                break;
        }

        return result;
    }
}
