using System;
using System.Windows.Forms;

namespace MainApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            _remainingPieChart.Initialize(DateTime.Now, new DateTime(2022, 12, 17,17,20,0));
            // _remainingPieChart.TimeOverObservable.Subscribe(_ => MessageBox.Show("Time Over"));
        }

        private void _addButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}