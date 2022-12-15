using System;
using System.Windows.Forms;

namespace Main
{
    public partial class MainForm : Form
    {　　　　　　　　　　　　　　　　　
        public MainForm()
        {
            InitializeComponent();
            remainingTimerChartControl1.Initialize(DateTime.Now, new DateTime(2022,12,16));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new RemainingPieChartDialog();
            form2.Set(DateTime.Now, new DateTime(2022, 12, 11, 15, 0, 0));
            form2.Show();
        }
    }
}