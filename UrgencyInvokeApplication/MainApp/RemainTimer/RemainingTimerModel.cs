using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Timers;

namespace MainApp.RemainTimer
{
    public class RemainingTimerModel
    {
        private DateTime _startDate;
        private DateTime _limitDate;
        private readonly Timer _timer = new Timer();
        private readonly Subject<TimeSpan> _remainingSubject = new Subject<TimeSpan>();
        private readonly BehaviorSubject<bool> _isTimeOverChangedSubject = new BehaviorSubject<bool>(false);
        
        public IObservable<TimeSpan> RemainingObservable => _remainingSubject.AsObservable();
        public IObservable<bool> IsTimeOverChangedObservable => _isTimeOverChangedSubject.AsObservable();

        public TimeViewType ViewType { get; private set; } = TimeViewType.Full;

        public RemainingTimerModel(DateTime limitDate)
        {
            _limitDate = limitDate;
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            _timer.Interval = 100;
            _timer.Elapsed += OnTimerElapse;
        }

        public void SetStartDate(DateTime dateTime)
        {
            _startDate = dateTime;
        }

        public void Start()
        {
            _timer.Start();
        }

        public TimeSpan GetRemainingTime()
        {
            var remainTime = _limitDate - DateTime.Now;
            return remainTime.TotalSeconds > 0 ? remainTime : TimeSpan.Zero;
        }

        public TimeSpan GetPassedTime()
        {
            return IsTimeOver() ? _limitDate - _startDate : DateTime.Now - _startDate;
        }

        private bool IsTimeOver()
        {
            return _limitDate < DateTime.Now;
        }

        private void OnTimerElapse(object sender, ElapsedEventArgs e)
        {
            _remainingSubject.OnNext(GetRemainingTime());
            var isTimeOver = IsTimeOver();
            if (_isTimeOverChangedSubject.Value != isTimeOver)
            {
                _isTimeOverChangedSubject.OnNext(isTimeOver);
            }
        }

        public void ChangeViewType()
        {
            ViewType = (TimeViewType) ((int) (ViewType + 1) % Enum.GetValues(typeof(TimeViewType)).Length);
        }
    }
}