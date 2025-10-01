namespace cheat
{
    public class Deck
    {
        private List<Card> cards;
        private Random rng = new Random();

        public Deck()
        {
            cards = new List<Card>();
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] names = { "Ace", "2", "3", "4", "5", "6", "7",
                               "8", "9", "10", "Jack", "Queen", "King" };

            for (int s = 0; s < suits.Length; s++)
            {
                for (int v = 0; v < names.Length; v++)
                {
                    // Values: Ace = 1, 2-10 = face value, Jack = 11, Queen = 12, King = 13
                    cards.Add(new Card(names[v], suits[s], v + 1));
                }
            }
        }
        public void Shuffle()
        {
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }

        public Card Deal()
        {
            if (cards.Count == 0)
                throw new InvalidOperationException("No cards left to deal!");
            Card top = cards[0];
            cards.RemoveAt(0);
            return top;
        }
    }
}
