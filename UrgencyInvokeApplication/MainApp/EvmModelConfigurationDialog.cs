using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MainApp.Evm.Content;

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

        private void _btnCreate_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void _cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }

    public class EvmModelConfigureResult
    {
        // タイトル
        public string Title { get; }

        // 開始日
        public DateTime Start { get; }

        // 期限
        public DateTime End { get; }

        // Pvのリスト
        public PvPointList PvValueList { get; }

        internal static EvmModelConfigureResult Create(
            string title,
            DateTime start,
            DateTime end,
            IDictionary<DayOfWeek, double> pvValueMap)
        {
            // 開始日を含めるので期間に1足す
            var dayCount = (end - start).Days + 1;
            var startDayOfWeek = start.DayOfWeek;
            var pvPointList = new PvPointList();
            for (var i = 0; i < dayCount; i++)
            {
                var dayOfWeek = startDayOfWeek + i % pvValueMap.Count;
                pvPointList.Add(EvmValue.CreateFromHour(pvValueMap[dayOfWeek]));
            }

            return new EvmModelConfigureResult(title, start, end, pvPointList);
        }

        private EvmModelConfigureResult(string title, DateTime start, DateTime end, PvPointList pvValueList)
        {
            Title = title;
            Start = start;
            End = end;
            PvValueList = pvValueList;
        }
    }
}