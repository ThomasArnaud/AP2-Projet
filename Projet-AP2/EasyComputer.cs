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
        public EasyComputer(Byte number, String name, Color color) : base(number, name, color)
        {
            
        }

        public override Byte Play()
        {
            Random rnd = new Random((int) DateTime.Now.Ticks & 0x0000FFFF + this.number);
            return this.cards[rnd.Next(this.cards.Count)];
        }
    }
}
