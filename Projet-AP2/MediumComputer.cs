using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Projet_AP2
{
    public class MediumComputer : ComputerPlayer
    {
        /// <summary>
        /// Holds a reference to a random numbers generator.
        /// </summary>
        protected Random random;

        /// <summary>
        /// Represents the threshold from which a card is valuable.
        /// </summary>
        protected SByte threshold;

        /// <summary>
        /// Creates a new medium computer.
        /// </summary>
        /// <param name="number">Player's number.</param>
        /// <param name="name">Player's name.</param>
        /// <param name="color">Player's color.</param>
        /// <param name="threshold">Threshold from which a card is valuable.</param>
        /// <see cref="Projet_AP2.Player.Player(Byte, String, Color)"/>
        public MediumComputer(Byte number, String name, Color color, SByte threshold = 6) : base(number, name, color)
        {
            this.random = new Random(10 + (this.number * 17 % 5));
            this.threshold = threshold;
        }

        /// <summary>
        /// Asks a player for the card to play knowing the card on top of the deck.
        /// Cards are distributed in three sets which represents the cards to use when
        /// the card on top of the deck is valuable, when it is negative and when it
        /// is not that valuable.
        /// Then, a random card is chosen in the according range.
        /// </summary>
        /// <param name="deckCard">Value of the card on the top of the deck.</param>
        /// <see cref="Projet_AP2.Player.Play(SByte)"/>
        public override Byte Play(SByte deckCard)
        {
            // Determine which cards to play in what condition
            List<Byte> forBest = new List<Byte>();
            List<Byte> forNegative = new List<Byte>();
            List<Byte> forMedium = new List<Byte>();

            for(Byte i = 0; i < this.cards.Count; i++)
            {
                if(this.cards[i] < 8)
                    forMedium.Add(this.cards[i]);
                else if(this.cards[i] >= 8)
                {
                    if(this.cards[i] <= 12)
                        forNegative.Add(this.cards[i]);

                    if(this.cards[i] >= 10)
                        forBest.Add(this.cards[i]);
                }
            }

            // Now, choose a card to play
            if(deckCard >= this.threshold)
                // Valuable cards
                return forBest.Count > 0 ? forBest[this.random.Next(forBest.Count)] : this.cards[this.random.Next(this.cards.Count)];
            else if(deckCard < 0)
                // Negative cards
                return forNegative.Count > 0 ? forNegative[this.random.Next(forNegative.Count)] : this.cards[this.random.Next(this.cards.Count)];
            else
                // Not that valuable card
                return forMedium.Count > 0 ? forMedium[this.random.Next(forMedium.Count)] : this.cards[this.random.Next(this.cards.Count)];
        }
    }
}
