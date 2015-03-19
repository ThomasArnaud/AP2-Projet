using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP2
{
    public class StupidVulture
    {
        /// <summary>
        /// Represents the list of currently playing players.
        /// </summary>
        protected List<Player> players;

        /// <summary>
        /// Represents the deck of card which are hidden.
        /// </summary>
        protected Stack<Card> deck;

        /// <summary>
        /// Creates a new game of Stupid Vulture.
        /// </summary>
        /// <param name="players">List of players for the game.</param>
        public StupidVulture(List<Player> players)
        {
            this.players = players;
        }
    }
}
