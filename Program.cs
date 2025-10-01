namespace cheat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();

            // Each player gets 13 cards (52 / 4 players)
            Card[][] players = new Card[4][];
            for (int i = 0; i < 4; i++)
                players[i] = new Card[13];

            for (int round = 0; round < 13; round++)
            {
                for (int player = 0; player < 4; player++)
                {
                    players[player][round] = deck.Deal();
                }
            }

            // Print players' hands
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Player {i + 1}'s hand:");
                foreach (Card c in players[i])
                {
                    Console.WriteLine(c);
                }
                Console.WriteLine();
            }
        }
    }
}
