using System;
using System.Collections.Generic;
using System.Linq;

namespace playingCards
{
    internal class Deck
    {
        List<Card> cards = new List<Card> { };
        public Deck()
        {
            for (int i = 1; i <= 4; i++) //suits
                for (int j = 1; j <= 13; j++) //ranks
                    cards.Add(new Card(i, j));
        }

        public void View()
        {
            foreach (var card in cards)
                Console.WriteLine(card.suit + " " + card.rank); 
        }

        public void Shuffle()
        {
            cards = cards.OrderBy(c => Guid.NewGuid()).ToList();
        }

        public void GetRandomCard()
        {
            Random random= new Random();
            int rnd = random.Next(52);
            Console.WriteLine("Your random card is: "+cards[rnd].suit +" " + cards[rnd].rank);

            cards.Remove(cards[rnd]);
        }

        public void GetTopCard()
        {
            Console.WriteLine("The top card is: "+cards[0].suit +" "+cards[0].rank);
            cards.Remove(cards[0]);
        }

        public void GetBottomCard()
        {
            Console.WriteLine("The bottom card is: " + cards[cards.Count-1].suit + " " + cards[cards.Count-1].rank);
            cards.Remove(cards[cards.Count - 1]);
        }
    }
}