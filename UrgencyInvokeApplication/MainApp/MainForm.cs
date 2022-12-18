using System;
using System.Windows.Forms;
using MainApp.Evm;

namespace MainApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            _remainingPieChart.Initialize(DateTime.Now, new DateTime(2022, 12, 17,17,20,0));
            
            ControlWindowBase f = new ControlWindowBase();
            var orthogonalGraphControl = new OrthogonalGraphControl();
            f.SetControl(orthogonalGraphControl);
            f.Show();
        }

        private void _addButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}