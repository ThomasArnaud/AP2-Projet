using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Projet_AP2
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(Byte number, String name, Color color) : base(number, name, color)
        {
        }

        public override Byte Play(SByte deckCard)
        {
            throw new NotImplementedException("This method shouldn't be called.");
        }
    }
}
