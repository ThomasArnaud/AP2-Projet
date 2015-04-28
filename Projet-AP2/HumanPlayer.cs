using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Projet_AP2
{
    public class HumanPlayer : Player
    {
        /// <summary>
        /// Creates a new human player.
        /// </summary>
        /// <param name="number">Player's number.</param>
        /// <param name="name">Player's name.</param>
        /// <param name="color">Player's color.</param>
        public HumanPlayer(Byte number, String name, Color color) : base(number, name, color)
        {
        }

        /// <summary>
        /// This method shouldn't be called because it is handled by the main window.
        /// </summary>
        public override Byte Play(SByte deckCard)
        {
            throw new NotImplementedException("This method shouldn't be called.");
        }
    }
}
