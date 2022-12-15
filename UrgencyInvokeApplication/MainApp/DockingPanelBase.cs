using System.Windows.Forms;

namespace Main
{
    public partial class DockingPanelBase : Form
    {
        private Control _dockingControl;
        
        public DockingPanelBase()
        {
            InitializeComponent();
        }

        public void Initialize(Control control)
        {
            SetControl(control);
            control.Dock = DockStyle.Fill;
        }
        
        private void SetControl(Control control)
        {
            _dockingControl = control;
        }
    }
}