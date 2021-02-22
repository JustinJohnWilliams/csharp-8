using System.Collections.Generic;

public enum CardSuit
{
    Clubs,
    Diamonds,
    Hearts,
    Spades,
    Unknown,
}

public enum CardValue
{
    Ace,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King,
    Joker,
}

public class Card
{
    public CardSuit Suit { get; set; }

    public CardValue Value { get; set; }

    public override string ToString()
    {
        return CardDescriber.Describe(this);
    }
}

public static class Game
{
    public static IEnumerable<CardValue> FaceCards = new[] { CardValue.Jack, CardValue.Queen, CardValue.King };
}
