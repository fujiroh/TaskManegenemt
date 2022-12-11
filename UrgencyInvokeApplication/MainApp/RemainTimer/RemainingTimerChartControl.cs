using System;
using System.Timers;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using ControlPropertyProvider = Main.PieChart.ControlPropertyProvider;
using PieChartList = Main.PieChart.PieChartList;

namespace Main.RemainTimer
{
    public partial class RemainingTimerChartControl : UserControl,IDockContent
    {
        private RemainingTimerModel _remainingTimerModelModel;
        private Main.RemainTimer.TimeContentFactory _timeContentFactory;
        
        public IObservable<bool> TimeOverObservable => _remainingTimerModelModel.IsTimeOverChangedObservable;

        public RemainingTimerChartControl()
        {
            InitializeComponent();
        }

        public void Initialize(DateTime startDate, DateTime limitDate)
        {
            _remainingTimerModelModel = new RemainingTimerModel(limitDate);
            _remainingTimerModelModel.SetStartDate(startDate);
            _timeContentFactory = new Main.RemainTimer.TimeContentFactory(_remainingTimerModelModel, new ControlPropertyProvider(this));
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

        public void ApplyTheme()
        {
        }

        public void OnActivated(EventArgs e)
        {
        }

        public void OnDeactivate(EventArgs e)
        {
        }

        public DockContentHandler DockHandler { get; }
    }
}