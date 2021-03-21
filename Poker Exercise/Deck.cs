using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Poker_Exercise
{    class Deck
    {
        public List<Card> CardDeck = new List<Card>();
        public List<Card> DrawnCards = new List<Card>();
        public string winner = "";

        public void PopulateDeck() // Populate the deck with 52 cards.
        {
            foreach (Card.CardSuit suit in Enum.GetValues(typeof(Card.CardSuit)))
            {
                foreach (int value in Enum.GetValues(typeof(Card.CardFace)))
                {
                    CardDeck.Add(new Card(value, suit));
                }
            }
        }
        public void ShuffleDeck() //Uses Fisher-Yates' shuffle algorithm
        {
            CardDeck.Shuffle();
        }
        public void DrawDeck(int DrawCount) //Draws 5 cards for each player
        {
            Console.WriteLine("Welcome to Poker!");
            
            foreach (Player.Players player in Enum.GetValues(typeof(Player.Players)))
            {
                Console.WriteLine();
                Console.WriteLine(player);
                for (int i = 0; i < DrawCount; i++)
                {
                    DrawnCards.Add(new Card(CardDeck[0].Value, CardDeck[0].Suite));
                    var face = (Card.CardFace)DrawnCards[i].Value;
                    CardDeck.RemoveAt(0);
                }
                ShowResult(player.ToString());
            }
        }
        public void ShowResult(string player) // Show the drawn cards
        {
            int i = 0;
            foreach(Card card in DrawnCards)
            {
                var face = (Card.CardFace)DrawnCards[i].Value;
                i++;
                Console.WriteLine(face + " of " + card.Suite.ToString());                
            }
            DrawnCards.Clear();
            //Console.WriteLine("Cards left in the deck: " + CardDeck.Count); //  Comment this out!
            //PokerHand(player);
        }
        public void PokerHand(string player) // implement poker hands rankings
        {
            winner = "The winner is " + player;
            Console.WriteLine(winner);
        }
    }

    static class Ext //Fisher-Yates shuffle algorithm https://stackoverflow.com/questions/273313/randomize-a-listt
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            var provider = new RNGCryptoServiceProvider();
            int n = list.Count;
            while (n > 1)
            {
                var box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                var k = (box[0] % n);
                n--;
                var value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
