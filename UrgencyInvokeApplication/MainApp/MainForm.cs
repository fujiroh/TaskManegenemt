using System.Windows.Forms;

namespace MainApp
{
    public partial class MainForm : Form
    {
        private MainController _controller = new MainController();
        public MainForm()
        {
            InitializeComponent();
            _controller.CreateNewEvm();
        }
    }
}