using System.Drawing;

namespace MainApp.PieChart
{
    public interface IPieChartContentFactory
    {
        PieDrawInfo CreateDrawInfo(Point centerPoint, Size size, double startAngle, double sweepAngle);
    }
}