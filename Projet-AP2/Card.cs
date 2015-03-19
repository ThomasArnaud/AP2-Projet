using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP2
{
    public class Card
    {
        /// <summary>
        /// Represents the number on a card.
        /// </summary>
        protected SByte number;

        /// <summary>
        /// Gets a card's number.
        /// </summary>
        public SByte Number
        {
            get 
            {
                return this.number;
            }
        }

        /// <summary>
        /// Creates a new card.
        /// </summary>
        /// <param name="number">Number on the card.</param>
        public Card(SByte number)
        {
            this.number = number;
        }
    }
}
