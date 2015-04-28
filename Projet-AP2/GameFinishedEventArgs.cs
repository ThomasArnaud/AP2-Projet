using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP2
{
    public class GameFinishedEventArgs : EventArgs
    {
        /// <summary>
        /// Holds a reference to the list of winners.
        /// </summary>
        protected List<Player> winnersList;

        /// <summary>
        /// Gets the list of winners.
        /// </summary>
        public List<Player> Winners
        {
            get
            {
                return this.winnersList;
            }
        }

        /// <summary>
        /// Tests if the victory is a draw.
        /// </summary>
        public Boolean IsDraw
        {
            get
            {
                return this.winnersList.Count > 1;
            }
        }

        /// <summary>
        /// Represents the highest score of the game.
        /// </summary>
        protected SByte highestScore;

        /// <summary>
        /// Gets the highest score of the game.
        /// </summary>
        public SByte HighestScore
        {
            get
            {
                return this.highestScore;
            }
        }

        /// <summary>
        /// Creates new arguments for a GameFinished event.
        /// </summary>
        /// <param name="winnersList">Reference to the list of winners.</param>
        /// <param name="highestScore">Highest score of the game.</param>
        public GameFinishedEventArgs(List<Player> winnersList, SByte highestScore) : base()
        {
            this.winnersList = winnersList;
            this.highestScore = highestScore;
        }
    }
}
