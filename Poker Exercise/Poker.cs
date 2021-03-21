using System;
using System.Collections.Generic;
using System.Text;

namespace Poker_Exercise
{
    class Poker
    {
        Deck deck = new Deck();
        public void InitialiseCardGame()
        {
            // Populate and shuffle the deck.
            deck.PopulateDeck();
            deck.ShuffleDeck();
            StartPoker(); //Start the game.
        }
        public void StartPoker()
        {
            deck.DrawDeck(5);
        }
    }
}
