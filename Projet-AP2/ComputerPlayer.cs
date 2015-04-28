using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Projet_AP2
{
    public abstract class ComputerPlayer : Player
    {
        /// <summary>
        /// Creates a new computer player.
        /// </summary>
        /// <param name="number">Player's number.</param>
        /// <param name="name">Player's name.</param>
        /// <param name="color">Player's color.</param>
        /// <see cref="Projet_AP2.EasyComputer.EasyComputer(Byte, String, Color, Byte)"/>
        /// <see cref="Projet_AP2.MediumComputer.MediumComputer(Byte, String, Color, SByte)"/>
        /// <see cref="Projet_AP2.HardComputer.HardComputer(Byte, String, Color, Byte, SByte)"/>
        public ComputerPlayer(Byte number, String name, Color color) : base(number, name, color)
        {
        }
    }
}
