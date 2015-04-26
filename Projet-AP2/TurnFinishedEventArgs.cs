using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP2
{
    public class TurnFinishedEventArgs : EventArgs
    {
        protected Player winner;

        public Player Winner
        {
            get
            {
                return this.winner;
            }
        }

        protected SByte wonCard;

        public SByte WonCard
        {
            get
            {
                return this.wonCard;
            }
        }

        protected Byte playedCard;

        public Byte PlayedCard
        {
            get
            {
                return this.playedCard;
            }
        }

        public TurnFinishedEventArgs(Player winner, SByte wonCard, Byte playedCard) : base()
        {
            this.winner = winner;
            this.wonCard = wonCard;
            this.playedCard = playedCard;
        }
    }
}
