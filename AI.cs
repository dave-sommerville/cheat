using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cheat
{
    public class AI : Player
    {

        public AI() { }

        // Plot out turn sequence for player, figure out entire history of valid plays 
        // If Truth an option then truth ** Unless
            // You only have 1 of the value card
            // You have single copy of unplayable card
            // Your truth score is high enough to bluff
        // If forced to bluff, follow these protocols:
            // Discard an otherwise unplayable card
            // Discard lower value at beginning of round
            // Discard higher value at end of round
        // Accusation protocol:
            // If self.Hand and the claimed cards > 4, accuse
            // If that card is player's last card, accuse (usually)
            // Trigger a judgement if on second round and player exceeds previous claims
            // Allow for a random accusation
    }
}
