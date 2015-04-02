using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Projet_AP2
{
    public class HardComputer : ComputerPlayer
    {
        public HardComputer(Byte number, String name, Color color) : base(number, name, color)
        {

        }

        public override Byte Play()
        {
            return 0;
        }
    }
}
