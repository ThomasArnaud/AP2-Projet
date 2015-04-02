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
        public List<Byte> Cards
        {
            get
            {
                return this.cards;
            }
        }

        public HumanPlayer(Byte number, String name, Color color) : base(number, name, color)
        {

        }
    }
}
