using System;
using System.Drawing;

namespace Main.PieChart
{
    /// <summary>
    /// 円グラフに表示する要素
    /// </summary>
    public class PieChartContent : Main.PieChart.IPieChartContent, IEquatable<PieChartContent>
    {
        public PieChartContent(double value, string contentTitle, Color pieColor)
        {
            Value = value;
            ContentTitle = contentTitle;
            PieColor = pieColor;
        }

        public bool Equals(PieChartContent other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Value.Equals(other.Value) && ContentTitle == other.ContentTitle;
        }

        public double Value { get; }
        public string ContentTitle { get; }
        public Color PieColor { get; }

        public PieDrawInfo CreateDrawInfo(Point centerPoint, Size size, double startAngle, double sweepAngle)
        {
            return PieDrawInfo.Create(centerPoint, size, startAngle, sweepAngle, PieColor, ContentTitle);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((PieChartContent) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Value.GetHashCode() * 397) ^ (ContentTitle != null ? ContentTitle.GetHashCode() : 0);
            }
        }
    }
}