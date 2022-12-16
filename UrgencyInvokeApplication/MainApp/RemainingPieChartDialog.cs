using System;
using System.Drawing;
using Main.RemainTimer;

namespace Main
{
    public partial class RemainingPieChartDialog : DockingPanelBase
    {
        private readonly RemainingTimerChartControl _remainingTimerChartControl = new RemainingTimerChartControl();

        public RemainingPieChartDialog()
        {
            InitializeComponent();
            _remainingTimerChartControl.RemainTimeColor  = Color.Red;
            _remainingTimerChartControl.PassedTimeColor = Color.Transparent;
            SetInitialControl(_remainingTimerChartControl);
        }

        public void Set(DateTime startDate, DateTime limitTime)
        {
            _remainingTimerChartControl.Initialize(startDate, limitTime);
        }

        private void SetStartingWindowParameter()
        {
            
        }
    }
}