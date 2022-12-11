using System;
using System.Windows.Forms;

namespace Main
{
    public partial class RemainingPieChartDialog : Form
    {
        public RemainingPieChartDialog()
        {
            InitializeComponent();
        }

        public void Set(DateTime startDate, DateTime limitTime)
        {
            _remainingTimerChartControl.Initialize(startDate, limitTime);
        }
    }
}