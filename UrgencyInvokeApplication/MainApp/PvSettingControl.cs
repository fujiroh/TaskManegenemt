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

        public IDictionary<DayOfWeek, DateAndNumericControl> PvValueMap => _eachDatePvSetControl.Map;

        public PvSettingControl()
        {
            InitializeComponent();
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