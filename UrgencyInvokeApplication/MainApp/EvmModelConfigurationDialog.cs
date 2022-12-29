using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainApp
{
    public partial class EvmModelConfigurationDialog : Form
    {
        private IDictionary<DayOfWeek, double> _pvValueMap =>
            _pvSettingControl.PvValueMap.ToDictionary(kv => kv.Key, kv => kv.Value.Value);

        public EvmModelConfigurationDialog()
        {
            InitializeComponent();
        }

        public EvmModelConfigureResult CreateResult()
        {
            return EvmModelConfigureResult.Create(
                _titleText.Text,
                _startDateTimePicker.Value,
                _limitDateTimePicker.Value,
                _pvValueMap);
        }

        private bool CheckValidateResult()
        {
            return _startDateTimePicker.Value < _limitDateTimePicker.Value;
        }

        private void _btnCreate_Click(object sender, EventArgs e)
        {
            if (CheckValidateResult())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void _cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}