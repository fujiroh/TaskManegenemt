using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp
{
    public partial class PvSettingControl : UserControl
    {
        private readonly ToggleChanger _toggleChanger;
        private readonly IDisposable _subscribe;
        private bool _SetAllAtOnce => _pvAllSetAtOnceCheckBox.Checked;
        
        public IDictionary<DayOfWeek, double> PvValueMap { get; }

        public PvSettingControl()
        {
            InitializeComponent();

            var enumLength = Enum.GetValues(typeof(DayOfWeek)).Length;
            PvValueMap = Enumerable.Range(0, enumLength).ToDictionary(x => (DayOfWeek) x, _ => 0.0);
            _subscribe = _eachDatePvSetControl.ValueChangedObservable.Subscribe(SetPvValue);
            _toggleChanger = new ToggleChanger(new[] {_pvAllSetAtOnceCheckBox, _pvSetEachDayCheckBox});
        }

        private void SetPvValue(double pvValue)
        {
            if (_SetAllAtOnce)
            {
                SetAllValueAtOnce(pvValue);
            }
        }

        private void SetAllValueAtOnce(double value)
        {
            foreach (var v in _eachDatePvSetControl.Map.Values)
            {
                v.Value = value;
            }
        }

        private void DisposeInternal()
        {
            using (_subscribe)
            using (_toggleChanger)
            {
            }
        }
    }
}