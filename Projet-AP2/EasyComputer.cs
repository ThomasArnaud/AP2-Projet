using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Projet_AP2
{
    public class EasyComputer : ComputerPlayer
    {
        /// <summary>
        /// Holds a reference to a random numbers generator.
        /// </summary>
        protected Random random;

        /// <summary>
        /// Represents the maximum size of the playable cards' range.
        /// </summary>
        protected Byte rangeMaximumSize;

        /// <summary>
        /// Creates a new easy computer.
        /// </summary>
        /// <param name="number">Player's number.</param>
        /// <param name="name">Player's name.</param>
        /// <param name="color">Player's color.</param>
        /// <param name="rangeMaximumSize">Maximum size of the playable cards' range.</param>
        /// <see cref="Projet_AP2.Player.Player(Byte, String, Color)"/>
        public EasyComputer(Byte number, String name, Color color, Byte rangeMaximumSize = 3) : base(number, name, color)
        {
            this.random = new Random(1 + (this.number * 13 % 9));
            this.rangeMaximumSize = rangeMaximumSize;
        }

        /// <summary>
        /// Asks a player for the card to play knowing the card on top of the deck.
        /// To prevent the computer from winning without trying, the range of cards
        /// it can play is restricted to a small number.
        /// </summary>
        /// <param name="deckCard">Value of the card on the top of the deck.</param>
        /// <see cref="Projet_AP2.Player.Play(SByte)"/>
        public override Byte Play(SByte deckCard)
        {
            return this.cards.Count >= this.rangeMaximumSize
                ? this.cards[this.random.Next(this.cards.Count - this.rangeMaximumSize) + this.random.Next(this.rangeMaximumSize)]
                : this.cards[this.random.Next(this.cards.Count)]
            ;
        }
    }
}
