using System.Windows.Forms;

namespace Main
{
    /// <summary>
    /// 単一のコントロールを表示する用のダイアログ基底クラス
    /// </summary>
    public partial class DockingPanelBase : Form
    {
        private Control _dockingControl;
        
        public DockingPanelBase()
        {
            InitializeComponent();
        }

        public void SetInitialControl(Control control)
        {
            _dockingControl = control;
            Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }
    }
}