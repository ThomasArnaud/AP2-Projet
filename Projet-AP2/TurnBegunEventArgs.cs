using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP2
{
    public class TurnBegunEventArgs
    {
        /// <summary>
        /// Holds a reference to the list of card played by each player.
        /// </summary>
        protected List<Pair<Player, Byte>> cardsList;

        /// <summary>
        /// Gets the list of card played by each player.
        /// </summary>
        public List<Pair<Player, Byte>> Cards
        {
            get
            {
                return this.cardsList;
            }
        }

        /// <summary>
        /// Creates new arguments for the TurnBegun event.
        /// </summary>
        /// <param name="cardsList">Reference to the list of card played by each player.</param>
        public TurnBegunEventArgs(List<Pair<Player, Byte>> cardsList) : base()
        {
            this.cardsList = cardsList;
        }
    }
}
