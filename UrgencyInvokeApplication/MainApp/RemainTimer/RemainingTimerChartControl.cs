using System;
using System.Timers;
using System.Windows.Forms;
using MainApp.PieChart;

namespace MainApp.RemainTimer
{
    public partial class RemainingTimerChartControl : UserControl
    {
        private RemainingTimerModel _remainingTimerModelModel;
        private TimeContentFactory _timeContentFactory;
        
        public IObservable<bool> TimeOverObservable => _remainingTimerModelModel.IsTimeOverChangedObservable;

        public RemainingTimerChartControl()
        {
            InitializeComponent();
        }

        public void Initialize(DateTime startDate, DateTime limitDate)
        {
            _remainingTimerModelModel = new RemainingTimerModel(limitDate);
            _remainingTimerModelModel.SetStartDate(startDate);
            _timeContentFactory = new TimeContentFactory(_remainingTimerModelModel, new ControlPropertyProvider(this));
            _pieChartControl.Contents = new PieChartList(new[]
            {
                _timeContentFactory.CreateRemainingTimeContent(),
                _timeContentFactory.CreatePassedTimeContent()
            });
            
            Start();
        }

        private void Start()
        {
            _remainingTimerModelModel.Start();
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _pieChartControl.Invalidate();
        }
    }
}