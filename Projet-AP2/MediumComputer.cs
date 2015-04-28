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
        protected SByte threshold;

        protected Random random;

        public MediumComputer(Byte number, String name, Color color, SByte threshold) : base(number, name, color)
        {
            this.threshold = threshold;
            this.random = new Random(this.number * 7 % 5);
        }

        public override Byte Play(SByte deckCard)
        {
            // Determine which cards to play in what condition
            List<Byte> forBest = new List<Byte>();
            List<Byte> forNegative = new List<Byte>();
            List<Byte> forMedium = new List<Byte>();

            for(Byte i = 0; i < this.cards.Count; i++)
            {
                if (this.cards[i] < 8)
                {
                    forMedium.Add(this.cards[i]);
                }
                else if (this.cards[i] >= 8)
                {
                    if(this.cards[i] <= 12)
                    {
                        forNegative.Add(this.cards[i]);
                    }

                    if(this.cards[i] >= 10)
                    {
                        forBest.Add(this.cards[i]);
                    }
                }
            }

            if(deckCard >= this.threshold)
            {
                return forBest.Count > 0 ? forBest[this.random.Next(forBest.Count)] : this.cards[this.random.Next(this.cards.Count)];
            }
            else if(deckCard < 0)
            {
                return forNegative.Count > 0 ? forNegative[this.random.Next(forNegative.Count)] : this.cards[this.random.Next(this.cards.Count)];
            }
            else
            {
                return forMedium.Count > 0 ? forMedium[this.random.Next(forMedium.Count)] : this.cards[this.random.Next(this.cards.Count)];
            }
        }
    }
}
