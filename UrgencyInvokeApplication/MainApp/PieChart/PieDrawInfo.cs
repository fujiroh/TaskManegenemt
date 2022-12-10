using System.Drawing;
using System.Drawing.Drawing2D;
using MainApp.Extension;

namespace MainApp.PieChart
{
    public class PieDrawInfo
    {
        private static Color _FramePenColor = Color.Black;
        private GraphicsPath _graphicsPath;

        public static PieDrawInfo Create(
            Point centerPoint,
            Size size,
            double startAngle,
            double sweepAngle,
            Color color,
            string contentTitle)
        {
            return new PieDrawInfo(centerPoint, size, startAngle, sweepAngle, color, contentTitle);
        }

        private PieDrawInfo(
            Point centerPoint,
            Size size, double startAngle,
            double sweepAngle,
            Color color,
            string contentTitle)
        {
            Size = size;
            StartAngle = startAngle;
            SweepAngle = sweepAngle;
            Color = color;
            CenterPoint = centerPoint;
            ContentTitle = contentTitle;
            _graphicsPath = new GraphicsPath();
            _graphicsPath.AddPie(this);
            _graphicsPath.FillMode = FillMode.Winding;
        }

        public Size Size { get; }
        public double StartAngle { get; }
        public double SweepAngle { get; }
        public Point CenterPoint { get; }
        public Color Color { get; }
        public string ContentTitle { get; }

        public void Draw(Graphics graphics)
        {
            var topLeft = new Point(CenterPoint.X - Size.Width / 2, CenterPoint.Y - Size.Height / 2);

            using (var brush = new SolidBrush(Color))
            using (var pens = new Pen(_FramePenColor))
            {
                graphics.FillPie(
                    brush,
                    topLeft.X,
                    topLeft.Y,
                    Size.Width,
                    Size.Height,
                    (float) StartAngle,
                    (float) SweepAngle);
                graphics.DrawPie(pens,
                    topLeft.X,
                    topLeft.Y,
                    Size.Width,
                    Size.Height,
                    (float) StartAngle,
                    (float) SweepAngle);
            }
        }

        public IPieChartValue CreateValueInfo()
        {
            return new PieValueInfo(ContentTitle, SweepAngle);
        }

        public bool HitTest(Point location)
        {
            return _graphicsPath.IsVisible(location);
        }
    }
}