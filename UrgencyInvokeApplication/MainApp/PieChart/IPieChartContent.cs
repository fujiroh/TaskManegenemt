using System.Drawing;

namespace Main.PieChart
{
    public interface IPieChartContent : IPieChartContentFactory
    {
        double Value { get; }
        string ContentTitle { get; }
        Color PieColor { get; }
    }
}