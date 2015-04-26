using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP2
{
    public class GameFinishedEventArgs : EventArgs
    {
        protected List<Player> winnersList;

        public List<Player> Winners
        {
            get
            {
                return this.winnersList;
            }
        }

        public Boolean IsDraw
        {
            get
            {
                return this.winnersList.Count > 1;
            }
        }

        protected SByte highestScore;

        public SByte HighestScore
        {
            get
            {
                return this.highestScore;
            }
        }

        public GameFinishedEventArgs(List<Player> winnersList, SByte highestScore) : base()
        {
            this.winnersList = winnersList;
            this.highestScore = highestScore;
        }
    }
}
