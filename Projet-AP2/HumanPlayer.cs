using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP2
{
    public class HumanPlayer : Player
    {
        public List<Card> Cards
        {
            get
            {
                return this.cards;
            }
        }
    }
}
