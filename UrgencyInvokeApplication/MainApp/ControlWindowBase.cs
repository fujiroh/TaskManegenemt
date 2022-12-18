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

        public void SetControl(Control control)
        {
            _control = control;
            this.Controls.Add(_control);
            Dock = DockStyle.Fill;
        }
    }
}