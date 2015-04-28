using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Projet_AP2
{
    public class HardComputer : ComputerPlayer
    {
        /// <summary>
        /// Holds a reference to a random numbers generator.
        /// </summary>
        protected Random random;

        /// <summary>
        /// Holds a reference to a hashtable containing list of cards played by every other players.
        /// </summary>
        protected Hashtable playedCards;

        /// <summary>
        /// Represents the threshold from which a card is valuable.
        /// </summary>
        protected SByte threshold;

        /// <summary>
        /// Represents the threshold from which it is considered safe to play a card.
        /// </summary>
        protected Byte safeNumber;

        /// <summary>
        /// Creates a new hard computer.
        /// </summary>
        /// <param name="number">Player's number.</param>
        /// <param name="name">Player's name.</param>
        /// <param name="color">Player's color.</param>
        /// <param name="playersNumber">Number of players.</param>
        /// <param name="threshold">Threshold from which a card is valuable.</param>
        /// <see cref="Projet_AP2.Player.Player(Byte, String, Color)"/>
        public HardComputer(Byte number, String name, Color color, Byte playersNumber, SByte threshold = 6) : base(number, name, color)
        {
            this.random = new Random(20 + (this.number * 19 % 7));
            this.playedCards = new Hashtable();
            this.threshold = threshold;
            
            switch(playersNumber)
            {
                case 2:
                    this.safeNumber = 1;
                break;

                case 3:
                case 4:
                    this.safeNumber = 2;
                break;

                case 5:
                    this.safeNumber = 3;
                break;
            }
        }

        /// <summary>
        /// Asks a player for the card to play knowing the card on top of the deck.
        /// The algorithm is based on the medium computer's one but it takes into
        /// account what every other player played: another threshold has been added.
        /// It represents the number of times a card must be played before it is considered
        /// safe to be played by the computer.
        /// </summary>
        /// <param name="deckCard">Value of the card on the top of the deck.</param>
        /// <see cref="Projet_AP2.Player.Play(SByte)"/>
        /// <see cref="Projet_AP2.MediumComputer.Play(SByte)"/>
        public override Byte Play(SByte deckCard)
        {
            // Determine which cards to play in what condition
            List<Byte> forBest = new List<Byte>();
            List<Byte> forNegative = new List<Byte>();
            List<Byte> forMedium = new List<Byte>();

            for (Byte i = 0; i < this.cards.Count; i++)
            {
                if(this.cards[i] < 8)
                    if(this.GetCardNumber(this.cards[i]) >= this.safeNumber)
                        forMedium.Add(this.cards[i]);
                else if(this.cards[i] >= 8)
                {
                    if(this.cards[i] <= 12 && this.GetCardNumber(this.cards[i]) >= this.safeNumber)
                        forNegative.Add(this.cards[i]);

                    if(this.cards[i] >= 10 && this.GetCardNumber(this.cards[i]) >= this.safeNumber)
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

        /// <summary>
        /// Helper method to get the number of times a card has already been played.
        /// </summary>
        /// <param name="card">Card's number.</param>
        /// <returns>Number of times the card has been played.</returns>
        protected Byte GetCardNumber(Byte card)
        {
            return this.playedCards.ContainsKey(card) ? (Byte) (this.playedCards[card]) : (Byte) 0;
        }

        /// <summary>
        /// Listens to the TurnFinished event of the game to fill up the hashtable
        /// containing how many times each card has been played.
        /// </summary>
        /// <param name="sender">Reference to the object that fired the event.</param>
        /// <param name="a">Reference to the arguments of the event.</param>
        public void OnTurnFinished(object sender, TurnFinishedEventArgs a)
        {
            foreach(Pair<Player, Byte> cardPair in a.Cards)
                if(this.playedCards.ContainsKey(cardPair.Second))
                    this.playedCards[cardPair.Second] = (Byte) (this.GetCardNumber(cardPair.Second) + 1);
                else
                    this.playedCards.Add(cardPair.Second, (Byte) 1);
        }
    }
}
