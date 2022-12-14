using System.Drawing;
using System.Windows.Forms;

namespace MainApp.PieChart
{
    public class ControlPropertyProvider : IControlPropertyProvider
    {
        private readonly Control _control;

        public ControlPropertyProvider(Control control)
        {
            _control = control;
        }

        public Size ProvideSize()
        {
            return _control.Size;
        }

        public Point ProvideCenterPoint()
        {
            return new Point(_control.Width / 2, _control.Height / 2);
        }
    }
}