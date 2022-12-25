using System;
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
            control.Dock = DockStyle.Fill;
            Controls.Add(_control);
        }

        private void ControlWindowBase_Load(object sender, EventArgs e)
        {
            _control.Invalidate();
        }
    }
}