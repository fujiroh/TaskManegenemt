using System.Drawing;
using System.Drawing.Drawing2D;
using Hazzik.Maybe;

namespace MainApp.PieChart
{
    public class PieChartDrawer
    {
        private const int INNER_CIRCLE_RADIUS = 50;
        private const float OUTER_CIRCLE_RATE = 0.90f;
        private static readonly Color _CirclePenColor = Color.Black;

        private readonly PieChartList _pieChartList;

        public PieChartDrawer(PieChartList pieChartList)
        {
            _pieChartList = pieChartList;
        }

        public void Draw(Graphics graphics,
            Point centerPoint,
            int pieLength,
            double displayValue,
            Color foreColor,
            Font font)
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var circleRadius = (int) (pieLength * OUTER_CIRCLE_RATE);
            var outerCircleDiameter = circleRadius * 2;
            DrawOuterCircle(graphics, centerPoint, circleRadius);
            FillPies(graphics, centerPoint, outerCircleDiameter);
            DrawInnerCircle(graphics, centerPoint, INNER_CIRCLE_RADIUS);
            DrawPercentageStr(graphics, centerPoint, displayValue, foreColor, font);
        }

        private static void DrawPercentageStr(Graphics graphics,
            Point centerPoint,
            double percentage,
            Color foreColor,
            Font font)
        {
            using (var format = new StringFormat())
            {
                format.LineAlignment = StringAlignment.Center;
                format.Alignment = StringAlignment.Center;
                using (var brush = new SolidBrush(foreColor))
                {
                    graphics.DrawString($"{percentage:F1}%", font, brush, centerPoint, format);
                }
            }
        }

        private void DrawOuterCircle(
            Graphics graphics,
            Point centerPoint,
            int outerCircleRadius)
        {
            FillPies(graphics, centerPoint, outerCircleRadius * 2);
            DrawCircle(graphics, centerPoint, outerCircleRadius, _CirclePenColor, 1.5f);
        }

        private void FillPies(Graphics graphics, Point centerPoint, int outerCircleDiameter)
        {
            var size = new Size(outerCircleDiameter, outerCircleDiameter);
            foreach (var pieDrawInfo in _pieChartList.CratePieShapeInfos(centerPoint, size))
                pieDrawInfo.Draw(graphics);
        }

        private static void DrawInnerCircle(Graphics graphics, Point centerPoint, float innerCircleRadius)
        {
            FillCircle(graphics, centerPoint, innerCircleRadius, Color.White);
            DrawCircle(graphics, centerPoint, innerCircleRadius, _CirclePenColor, 3.0f);
        }

        private static void FillCircle(Graphics graphics, PointF center, float radius, Color brushColor)
        {
            using (var brush = new SolidBrush(brushColor))
            {
                var diameter = radius * 2;
                graphics.FillEllipse(brush, center.X - radius, center.Y - radius, diameter, diameter);
            }
        }

        private static void DrawCircle(Graphics graphics, PointF center, float radius, Color penColor, float penWidth)
        {
            using (var pens = new Pen(penColor, penWidth))
            {
                var diameter = radius * 2;
                graphics.DrawEllipse(pens, center.X - radius, center.Y - radius, diameter, diameter);
            }
        }

        public Maybe<IPieChartValue> GetHitContent(Point location, Point centerPoint, Size size)
        {
            foreach (var pieShapeInfo in _pieChartList.CratePieShapeInfos(centerPoint, size))
            {
                var hitTest = pieShapeInfo.HitTest(location);
                if (hitTest)
                {
                    return new Maybe<IPieChartValue>(pieShapeInfo.CreateValueInfo());
                }
            }

            return Maybe<IPieChartValue>.Nothing;
        }
    }
}