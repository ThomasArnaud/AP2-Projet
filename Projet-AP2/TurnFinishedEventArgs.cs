using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP2
{
    public class TurnFinishedEventArgs : EventArgs
    {
        /// <summary>
        /// Holds a reference to the winner of the turn.
        /// </summary>
        protected Player winner;

        /// <summary>
        /// Gets the winner of the turn.
        /// </summary>
        public Player Winner
        {
            get
            {
                return this.winner;
            }
        }

        /// <summary>
        /// Holds the value of the card which was won.
        /// </summary>
        protected SByte wonCard;

        /// <summary>
        /// Gets the value of the card which was won.
        /// </summary>
        public SByte WonCard
        {
            get
            {
                return this.wonCard;
            }
        }

        /// <summary>
        /// Holds the value of the card that was used to win.
        /// </summary>
        protected Byte playedCard;

        /// <summary>
        /// Gets the value of the card that was used to win.
        /// </summary>
        public Byte PlayedCard
        {
            get
            {
                return this.playedCard;
            }
        }

        /// <summary>
        /// Holds a reference to the list of card that each player played.
        /// </summary>
        protected List<Pair<Player, Byte>> cardsList;

        /// <summary>
        /// Gets the list of card that each player played.
        /// </summary>
        public List<Pair<Player, Byte>> Cards
        {
            get
            {
                return this.cardsList;
            }
        }

        /// <summary>
        /// Creates new arguments for a TurnFinished event.
        /// </summary>
        /// <param name="winner">Reference to the player who won.</param>
        /// <param name="wonCard">Value of the card that was won.</param>
        /// <param name="playedCard">Value of the card that was used to win.</param>
        /// <param name="cardsList">Reference to the list of card that each player played.</param>
        public TurnFinishedEventArgs(Player winner, SByte wonCard, Byte playedCard, List<Pair<Player, Byte>> cardsList) : base()
        {
            this.winner = winner;
            this.wonCard = wonCard;
            this.playedCard = playedCard;
            this.cardsList = cardsList;
        }
    }
}
