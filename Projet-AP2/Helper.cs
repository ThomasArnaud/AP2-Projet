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
        public static PointF centerBlock(float X, float Y, float W, float H, float w, float h)
        {
            return new PointF(X + (W - w) / 2, Y + (H - h) / 2);
        }

        public static  PointF centerBlock(PointF outerBlockPosition, SizeF outerBlockSize, SizeF innerBlockSize)
        {
            return Helper.centerBlock(outerBlockPosition.X, outerBlockPosition.Y, outerBlockSize.Width, outerBlockSize.Height, innerBlockSize.Width, innerBlockSize.Height);
        }
    }
}
