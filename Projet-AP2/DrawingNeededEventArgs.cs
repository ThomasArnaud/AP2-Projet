using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP2
{
    class DrawingNeededEventArgs : EventArgs
    {
        protected List<Pair<Player, Byte>> cards;

        public List<Pair<Player, Byte>> Cards
        {
            get
            {
                return this.cards;
            }

            set
            {
                this.cards = value;
            }
        }
    }
}
