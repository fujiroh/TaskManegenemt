using System.Drawing;

namespace MainApp.PieChart
{
    public interface IPieChartContent : IPieChartContentFactory
    {
        double Value { get; }
        string ContentTitle { get; }
        Color PieColor { get; }
    }
}