using System.Drawing;
using System.Drawing.Drawing2D;
using MainApp.PieChart;

namespace MainApp.Extension
{
    public static class GraphicExtension
    {
        public static void AddPie(this GraphicsPath graphicsPath, PieDrawInfo pieDrawInfo)
        {
            var centerPoint = pieDrawInfo.CenterPoint;
            var size = pieDrawInfo.Size;
            var topLeft = new PointF(centerPoint.X - size.Width / 2, centerPoint.Y - size.Height / 2);

            graphicsPath.AddPie(
                topLeft.X,
                topLeft.Y,
                size.Width,
                size.Height,
                (float) pieDrawInfo.StartAngle,
                (float) pieDrawInfo.SweepAngle);
        }
    }
}