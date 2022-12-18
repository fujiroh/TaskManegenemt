using System;

namespace MainApp.PieChart
{
    /// <summary>
    /// 円グラフの値 
    /// </summary>
    public class PieValueInfo : IPieChartValue, IEquatable<PieValueInfo>
    {
        public string ContentTitle { get; }
        public double Ratio { get; }

        public PieValueInfo(string contentTitle, double sweepAngle)
        {
            ContentTitle = contentTitle;
            Ratio = sweepAngle / 360;
        }

        public static IPieChartValue Empty => new PieValueInfo("", 0);


        public bool Equals(PieValueInfo other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return ContentTitle == other.ContentTitle && Ratio.Equals(other.Ratio);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((PieValueInfo) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((ContentTitle != null ? ContentTitle.GetHashCode() : 0) * 397) ^ Ratio.GetHashCode();
            }
        }
    }
}