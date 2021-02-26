using System;
using System.Collections.Generic;
using System.Linq;

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

    public int CardValue => CardDescriber.CalculateValue(this);

    public override string ToString()
    {
        return CardDescriber.Describe(this);
    }
}

public class Player
{
    public Player(int age, string name)
    {
        Age = age;
        Name = name;
    }

    public int Age { get; private set; }
    public string Name { get; private set; }
    public Queue<Card> Hand { get; private set; } = new Queue<Card>();
    public Card Draw() => Hand.Any() ? Hand.Dequeue() : throw new EmptyHandException(Name);
}

public static class Game
{
    static Game()
    {
        Shuffle();
        while(CardDeck.Any())
        {
            Player1.Hand.Enqueue(Draw());
            Player2.Hand.Enqueue(Draw());
        }
    }

    private static Random Rand = new Random();

    public static Stack<Card> CardDeck { get; private set; } = new Stack<Card>();

    public static Player Player1 { get; private set; } = new Player(Rand.Next(10, 100), "Sushil");

    public static Player Player2 { get; private set; } = new Player(Rand.Next(10, 100), "Suyash");

    public static IEnumerable<CardValue> FaceCards = new[] { CardValue.Jack, CardValue.Queen, CardValue.King };

    public static Card Draw() => CardDeck.Pop();

    public static Stack<Card> Shuffle()
    {
        var deck = CardDeck.ToList();
        if(!deck.Any())
        {
            deck = BuildFullDeck().ToList();
        }

        CardDeck.Clear();
        while(deck.Any())
        {
            var randomCard = deck[Rand.Next(0, deck.Count)];
            CardDeck.Push(randomCard);
            deck.Remove(randomCard);
        }

        return CardDeck;
    }

    private static IEnumerable<Card> BuildFullDeck()
    {
        return new[] {
            BuildFourOfKind(CardValue.Ace),
            BuildFourOfKind(CardValue.Two),
            BuildFourOfKind(CardValue.Three),
            BuildFourOfKind(CardValue.Four),
            BuildFourOfKind(CardValue.Five),
            BuildFourOfKind(CardValue.Six),
            BuildFourOfKind(CardValue.Seven),
            BuildFourOfKind(CardValue.Eight),
            BuildFourOfKind(CardValue.Nine),
            BuildFourOfKind(CardValue.Ten),
            BuildFourOfKind(CardValue.Jack),
            BuildFourOfKind(CardValue.Queen),
            BuildFourOfKind(CardValue.King),
        }.SelectMany(c => c);
    }

    private static IEnumerable<Card> BuildFourOfKind(CardValue kind)
    {
        return new [] {
                new Card { Suit = CardSuit.Clubs, Value = kind },
                new Card { Suit = CardSuit.Diamonds, Value = kind },
                new Card { Suit = CardSuit.Hearts, Value = kind },
                new Card { Suit = CardSuit.Spades, Value = kind } };
    }
}

public class EmptyHandException : Exception
{
    public EmptyHandException(string playerName)
        : base($"{playerName} has no more cards left to draw!") { }
}
