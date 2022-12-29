using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Timers;
using System.Windows.Forms;
using MainApp.Evm.Content;

namespace MainApp
{
    public partial class AcTimerDialog : Form
    {
        private readonly Point _centerPoint;
        private readonly Stopwatch _stopwatch = new Stopwatch();

        public AcTimerDialog()
        {
            InitializeComponent();
            timer1.Interval = 500;
            _centerPoint = new Point(_timeView.Width / 2, _timeView.Height / 2);
        }

        public AcTimerResult CreateResult()
        {
            return new AcTimerResult((int) _stopwatch.Elapsed.TotalSeconds);
        }

        private void _startBtn_Click(object sender, EventArgs e)
        {
            _stopwatch.Start();
        }

        private void _stopBtn_Click(object sender, EventArgs e)
        {
            _stopwatch.Stop();
        }

        private void _finishBtn_Click(object sender, EventArgs e)
        {
            _stopwatch.Stop();
            Close();
        }

        private void _timeView_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (var format = new StringFormat())
            using (var font = new Font("Meiryo UI", 25f))
            using (var brush = new SolidBrush(ForeColor))
            {
                format.LineAlignment = StringAlignment.Center;
                format.Alignment = StringAlignment.Center;
                e.Graphics.DrawString($"{GetTimeStr()}", font, brush, _centerPoint, format);
            }
        }

        private string GetTimeStr()
        {
            var time = GetTime();
            return ArrangeTimeStr(time[0]) + ":" + ArrangeTimeStr(time[1]) + ":" + ArrangeTimeStr(time[2]);
        }

        private static string ArrangeTimeStr(int time)
        {
            var timeStr = time / 10 > 1 ? "" : "0";
            return timeStr + time;
        }

        private int[] GetTime()
        {
            var time = _stopwatch.Elapsed;
            return new[] {time.Hours, time.Minutes, time.Seconds};
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            _timeView.Invalidate();
        }
    }

    public class AcTimerResult
    {
        public EvmValue AcValue { get; }
        public DateTime CreateTime { get; }

        public AcTimerResult(int second)
        {
            AcValue = EvmValue.CreateFromSecond(second);
            CreateTime = DateTime.Now;
        }
    }
}