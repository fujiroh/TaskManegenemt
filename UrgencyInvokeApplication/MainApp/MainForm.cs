using System.Windows.Forms;
using MainApp.Evm;

namespace MainApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            EvmModelConfigurationDialog d = new EvmModelConfigurationDialog();
            d.Show();
            var orthogonalGraphControl = new OrthogonalGraphControl();
            Controls.Add(orthogonalGraphControl);
            orthogonalGraphControl.Dock = DockStyle.Fill;
        }
    }
}