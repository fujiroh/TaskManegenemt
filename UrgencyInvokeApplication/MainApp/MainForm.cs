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
        }

        private void _menuFileNewCreate_Click(object sender, EventArgs e)
        {
            _controller.CreateNewEvm();
        }
    }
}