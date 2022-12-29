using System;
using System.Windows.Forms;

namespace MainApp
{
    public partial class MainForm : Form
    {
        private MainController _controller = new MainController();
        public MainForm()
        {
            InitializeComponent();
            AcTimerDialog d = new AcTimerDialog();
            d.ShowDialog();
        }

        private void _menuFileNewCreate_Click(object sender, EventArgs e)
        {
            _controller.CreateNewEvm();
        }
    }
}