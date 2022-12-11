using System;
using System.Reactive.Disposables;
using System.Windows.Forms;

namespace Main.RemainTimer
{
    public partial class RemainingTimerControl : UserControl
    {
        private readonly RemainingTimerModel _remainingTimerModel;
        private IDisposable _subscriber;

        public RemainingTimerControl()
        {
            _remainingTimerModel = new RemainingTimerModel(new DateTime(2022, 10, 10));
            InitializeComponent();
            InitializeTimer();
            Subscribe();
        }

        public RemainingTimerControl(RemainingTimerModel remainingTimerModel)
        {
            _remainingTimerModel = remainingTimerModel;
            InitializeComponent();
            InitializeTimer();
            Subscribe();
        }

        private void InitializeTimer()
        {
            _timer.Interval = 100;
            _timer.Start();
        }

        private void Subscribe()
        {
            _subscriber = new CompositeDisposable(
                _remainingTimerModel.RemainingTimeObservable.Subscribe(_ => OnTimerElapsed()));
        }

        private string GetTimeViewString(TimeSpan remainingTime)
        {
            return "";
        }

        private void OnTimerElapsed()
        {
            var remainingTime = _remainingTimerModel.GetRemainingTime();
            _countDownTimerLabel.Text = GetTimeViewString(remainingTime);
        }

        private void DisposeInternal()
        {
            using (_subscriber)
            {
            }
        }
    }
}