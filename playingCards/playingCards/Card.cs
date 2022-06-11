using System;
using System.Collections.Generic;
using System.Text;

namespace playingCards
{
    public enum Suit
    {
        Club=1,
        Diamond=2,
        Heart=3,
        Spade=4,
    }
    public enum Rank
    {
        Ace=1,
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
    }
    public class Card
    {
        public Suit suit;
        public Rank rank;
        public Card (int suit, int rank)
        {
            this.suit = (Suit)suit;
            this.rank = (Rank)rank;
        }
    }
}
