using System.Drawing;

namespace Main.PieChart
{
    public interface IControlPropertyProvider
    {
        Size ProvideSize();
        Point ProvideCenterPoint();
    }
}