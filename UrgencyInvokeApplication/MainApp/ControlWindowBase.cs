using System.Windows.Forms;

namespace MainApp
{
    public partial class ControlWindowBase : Form
    {
        private Control _control;
        
        public ControlWindowBase()
        {
            InitializeComponent();
        }

        public void SetInitialControl(Control control)
        {
            _control = control;
            control.Dock = DockStyle.Fill;
            Controls.Add(_control);
        }
    }
}