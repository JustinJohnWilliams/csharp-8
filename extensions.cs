using System;

public static class extensions
{
    public static string FirstToUpper(this object cardProp)
    {
        switch(cardProp)
        {
            case CardSuit s:
                return s.ToString().ToUpper()[0].ToString();
            case CardValue v:
                return v.ToString().ToString()[0].ToString();
            default:
                throw new ArgumentException(
                    message: "cardProp is not a recognized card property",
                    paramName: nameof(cardProp));
        }
    }
}
