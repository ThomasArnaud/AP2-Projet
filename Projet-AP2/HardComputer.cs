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
        /// Holds a reference to a hashtable containing list of cards played by every other players.
        /// </summary>
        protected Hashtable playedCards;

        protected Byte playersNumber;

        protected SByte threshold;

        protected Byte safeNumber;

        protected Random random;

        public HardComputer(Byte number, String name, Color color, Byte playersNumber, SByte threshold) : base(number, name, color)
        {
            this.playedCards = new Hashtable();
            this.playersNumber = playersNumber;
            this.threshold = threshold;
            this.random = new Random(20 + (this.number * 19 % 7));
            
            switch(this.playersNumber)
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

        public override Byte Play(SByte deckCard)
        {
            // Determine which cards to play in what condition
            List<Byte> forBest = new List<Byte>();
            List<Byte> forNegative = new List<Byte>();
            List<Byte> forMedium = new List<Byte>();

            for (Byte i = 0; i < this.cards.Count; i++)
            {
                if (this.cards[i] < 8)
                {
                    if(this.GetCardNumber(this.cards[i]) >= this.safeNumber)
                        forMedium.Add(this.cards[i]);
                }
                else if (this.cards[i] >= 8)
                {
                    if (this.cards[i] <= 12 && this.GetCardNumber(this.cards[i]) >= this.safeNumber)
                    {
                        forNegative.Add(this.cards[i]);
                    }

                    if (this.cards[i] >= 10 && this.GetCardNumber(this.cards[i]) >= this.safeNumber)
                    {
                        forBest.Add(this.cards[i]);
                    }
                }
            }

            if (deckCard >= this.threshold)
            {
                return forBest.Count > 0 ? forBest[this.random.Next(forBest.Count)] : this.cards[this.random.Next(this.cards.Count)];
            }
            else if (deckCard < 0)
            {
                return forNegative.Count > 0 ? forNegative[this.random.Next(forNegative.Count)] : this.cards[this.random.Next(this.cards.Count)];
            }
            else
            {
                return forMedium.Count > 0 ? forMedium[this.random.Next(forMedium.Count)] : this.cards[this.random.Next(this.cards.Count)];
            }
        }

        protected Byte GetCardNumber(Byte card)
        {
            return this.playedCards.ContainsKey(card) ? (Byte) (this.playedCards[card]) : (Byte) 0;
        }

        public void OnTurnFinished(object sender, TurnFinishedEventArgs a)
        {
            foreach(Pair<Player, Byte> cardPair in a.Cards)
            {
                if(this.playedCards.ContainsKey(cardPair.Second))
                    this.playedCards[cardPair.Second] = (Byte) (this.GetCardNumber(cardPair.Second) + 1);
                else
                    this.playedCards.Add(cardPair.Second, (Byte) 1);
            }
        }
    }
}
