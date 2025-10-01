namespace cheat
{
    public class Player
    {
        public List<Card> Hand { get; private set; }
        public bool TellingTruth { get; set; }
        public bool IsAccused { get; set; }
        public Player()
        {
            Hand = new List<Card>();
            TellingTruth = true;
            IsAccused = false;
        }

        public void PrintHand()         {
            foreach (var card in Hand)
            {
                Console.WriteLine(card);
            }
        }
        public static int PrintMenu(int options)
        {
            int intDecision;
            bool isValid;
            do
            {
                string decision = Console.ReadLine();
                isValid = int.TryParse(decision, out intDecision) && intDecision >= 0 && intDecision <= options;
                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            } while (!isValid);
            return intDecision;
        }
        public void SortHand()
        {

        }
        public bool MatchesSequence(int seqIndex)
        {
            return false;
            // Search current player's hand for cards of the current sequence value
        }
        public void PrintAnySequenceCards()
        {
            // Iterates through hand and tells player what cards they have that work
        }

        public void SelectCards()
        {
            List<Card> cardQueue = new List<Card>();
            Console.WriteLine($"Select 4 cards to play (1-{Hand.Count}):");
            while (cardQueue.Count < 4)
            {
                int cardSelect = PrintMenu(Hand.Count);
                Card selectedCard = Hand[cardSelect - 1];
                if (!cardQueue.Contains(selectedCard) && cardSelect > 0 && cardSelect <= Hand.Count)
                {
                    cardQueue.Add(selectedCard);
                    Hand.Remove(selectedCard);
                }
                else
                {
                    Console.WriteLine("Invalid selection or card already selected. Please choose again.");
                }
                foreach (var card in cardQueue)
                {
                    Console.WriteLine($"Selected: {card.Name}");
                }
            }
        }
        public bool IsPlayHonest()
        {
            // Checks the card queue for honesty, with MatchesSequence function
            return false;
        }
        public void FinishTurn()
        {
            // If unchallenged or truth telling, makes discard, turn changes
        }
        public void Accuse(Player targetPlayer)
        {

        }
    }
}
