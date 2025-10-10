using System;
using System.Collections.Generic;
using System.Linq;

namespace cheat
{
    public class Card
    {
        public string Name { get; }
        public string Suit { get; }
        public int Value { get; }

        public Card(string name, string suit, int value)
        {
            Name = name;
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Name} of {Suit} (Value: {Value})";
        }
    }
}