using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP2
{
    public class DrawingNeededEventArgs : EventArgs
    {
        protected List<Pair<Player, Byte>> cardsList;

        public List<Pair<Player, Byte>> Cards
        {
            get
            {
                return this.cardsList;
            }

            set
            {
                this.cardsList = value;
            }
        }
    }
}
