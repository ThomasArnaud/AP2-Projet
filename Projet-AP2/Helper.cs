using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Projet_AP2
{
    public abstract class Helper
    {
        /// <summary>
        /// Centers a block inside another one.
        /// </summary>
        /// <param name="X">Outer block's abscissa.</param>
        /// <param name="Y">Outer block's ordinate.</param>
        /// <param name="W">Outer block's width.</param>
        /// <param name="H">Outer block's height.</param>
        /// <param name="w">Inner block's width.</param>
        /// <param name="h">Inner block's height.</param>
        /// <returns></returns>
        public static PointF centerBlock(float X, float Y, float W, float H, float w, float h)
        {
            return new PointF(X + (W - w) / 2, Y + (H - h) / 2);
        }

        /// <summary>
        /// Centers a block inside another one.
        /// </summary>
        /// <param name="outerBlockPosition">Outer block's position.</param>
        /// <param name="outerBlockSize">Outer block's size.</param>
        /// <param name="innerBlockSize">Inner block's size.</param>
        /// <returns></returns>
        public static  PointF centerBlock(PointF outerBlockPosition, SizeF outerBlockSize, SizeF innerBlockSize)
        {
            return Helper.centerBlock(outerBlockPosition.X, outerBlockPosition.Y, outerBlockSize.Width, outerBlockSize.Height, innerBlockSize.Width, innerBlockSize.Height);
        }
    }
}
