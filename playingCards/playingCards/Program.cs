using System;

namespace playingCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            Console.WriteLine("Initial deck: " + Environment.NewLine);
            deck.View();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Environment.NewLine + "Shuffled deck: ");
            deck.Shuffle();
            Console.WriteLine();
            deck.View();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            deck.GetRandomCard();
            deck.GetTopCard();
            deck.GetBottomCard();
           
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Environment.NewLine+"The deck without the random, the top and the bottom card is: "+Environment.NewLine);
            deck.View();
        }
    }
}
