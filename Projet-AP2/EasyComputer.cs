using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Projet_AP2
{
    public class EasyComputer : ComputerPlayer
    {
        protected Random random;

        public EasyComputer(Byte number, String name, Color color) : base(number, name, color)
        {
            this.random = new Random(1 + (this.number * 13 % 9));
        }

        public EasyComputer(Byte number, String name, Color color, Byte rangeMaximumSize) : this(number, name, color)
        {

        }

        public override Byte Play(SByte deckCard)
        {
            return this.cards[this.random.Next(this.cards.Count)];
        }
    }
}
