using System.Drawing;

namespace Main.PieChart
{
    public interface IPieChartContentFactory
    {
        PieDrawInfo CreateDrawInfo(Point centerPoint, Size size, double startAngle, double sweepAngle);
    }
}