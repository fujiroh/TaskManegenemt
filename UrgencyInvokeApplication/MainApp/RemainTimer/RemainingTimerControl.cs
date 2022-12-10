using System;
using System.Reactive.Disposables;
using System.Windows.Forms;

namespace MainApp.RemainTimer
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
            Click += OnTimerViewTypeChanged;
            _subscriber = new CompositeDisposable(
                _remainingTimerModel.RemainingObservable.Subscribe(_ => OnTimerElapsed()));
        }

        private string GetTimeViewString(TimeSpan remainingTime)
        {
            switch (_remainingTimerModel.ViewType)
            {
                case TimeViewType.Full:
                    return
                        $"{remainingTime.Days}日{remainingTime.Hours}時間{remainingTime.Minutes}分{remainingTime.Seconds}秒";
                case TimeViewType.Day: return $"{(int) remainingTime.TotalDays}日";
                case TimeViewType.Hour: return $"{(int) remainingTime.TotalHours}時間";
                case TimeViewType.Minute: return $"{(int) remainingTime.TotalMinutes}分";
                default: return "";
            }
        }

        private void OnTimerViewTypeChanged(object sender, EventArgs e)
        {
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