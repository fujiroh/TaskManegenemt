using System;
using System.Drawing;

namespace Main.Extension
{
    public static class SizeExtension
    {
        public static Size RoundSquare(this Size size)
        {
            var minEdge = Math.Min(size.Height, size.Width);
            return new Size(minEdge, minEdge);
        }
    }
}