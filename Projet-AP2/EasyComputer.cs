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
            this.random = new Random((int) DateTime.Now.Ticks & 0x0000FFFF + this.number);
        }

        public override Byte Play()
        {
            return this.cards[this.random.Next(this.cards.Count)];
        }
    }
}
