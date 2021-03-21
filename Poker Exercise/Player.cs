using System;
using System.Collections.Generic;
using System.Text;

namespace Poker_Exercise
{
    class Player
    {
        public enum Players // Enumeration of Players
        {
            Player1,
            Player2,
            Player3,
            Player4
        }
        public int Value
        {
            get;
            set;
        }
        public Card.CardSuit Suite
        {
            get;
            set;
        }
        public Players players
        {
            get;
            set;
        }
        public Player(Players players, int Value, Card.CardSuit Suite)
        {
            this.players = players;
            this.Value = Value;
            this.Suite = Suite;
        }
    }
}
