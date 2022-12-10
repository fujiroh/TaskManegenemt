using System.Drawing;

namespace MainApp.PieChart
{
    public interface IControlPropertyProvider
    {
        Size ProvideSize();
        Point ProvideCenterPoint();
    }
}