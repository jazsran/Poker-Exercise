using System;
using System.Collections.Generic;
using System.Text;

namespace Poker_Exercise
{
    class Card
    {
        public enum CardSuit // Enumeration of card suites
        {
            Clubs,
            Diamonds,
            Hearts,
            Spades
        }
        public enum CardFace // Enumeration of card faces/value
        {
            Two = 2,
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
            Ace
        }
        public int Value
        {
            get;
            set;
        }
        public CardSuit Suite
        {
            get;
            set;
        }
        public Card(int Value, CardSuit Suite)
        {
            this.Value = Value;
            this.Suite = Suite;
        }
    }
}
