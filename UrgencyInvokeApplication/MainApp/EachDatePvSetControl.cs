using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Windows.Forms;

namespace MainApp
{
    public partial class EachDatePvSetControl : UserControl
    {
        private readonly DateAndNumericControl[] _controlSet;
        private Subject<double> _subject = new Subject<double>();
        public IDictionary<DayOfWeek, DateAndNumericControl> Map { get; }
        public IObservable<double> ValueChangedObservable => _subject.AsObservable();

        public EachDatePvSetControl()
        {
            InitializeComponent();
            _controlSet = CreateControlSet();
            var dayOfWeek = Enum.GetValues(typeof(DayOfWeek)).Length;
            Map = Enumerable.Range(0, dayOfWeek).ToDictionary(idx => (DayOfWeek) idx, idx => _controlSet[idx]);
            InitializeSetControls();
        }

        private void InitializeSetControls()
        {
            for (var idx = 0; idx < _controlSet.Length; idx++)
            {
                InitializeSetControl(idx);
            }
        }

        private void InitializeSetControl(int idx)
        {
            var dayOfWeek = (DayOfWeek) idx;
            _controlSet[idx].Dock = DockStyle.Fill;
            _controlSet[idx].Set(dayOfWeek, GetColor(dayOfWeek));
            _controlSet[idx].ValueChanged += OnValueChanged;
        }

        private DateAndNumericControl[] CreateControlSet()
        {
            return new[]
            {
                _sunDayControl,
                _mondayControl,
                _tuesdayControl,
                _wednesdayControl,
                _thursdayControl,
                _fridayControl,
                _saturdayControl
            };
        }

        private static Color GetColor(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Saturday: return Color.Blue;
                case DayOfWeek.Sunday: return Color.Red;
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                default: return Color.Black;
            }
        }

        private void OnValueChanged(object sender, EventArgs e)
        {
            _subject.OnNext(((DateAndNumericControl) sender).Value);
        }
    }
}