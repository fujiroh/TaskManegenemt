using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainApp
{
    public partial class DateAndNumericControl : UserControl
    {
        public event EventHandler ValueChanged = delegate { };
        public DayOfWeek Day { get; set; }
        public Color TextColor { get; set; } = DefaultForeColor;

        public double Value
        {
            get => (double) _pvNumeric.Value;
            set => _pvNumeric.Value = (decimal)value;
        }

        public DateAndNumericControl()
        {
            InitializeComponent();
        }

        public void Set(DayOfWeek dayOfWeek, Color textColor)
        {
            Day = dayOfWeek;
            _dateLabel.Text = dayOfWeek.ToString();
            TextColor = textColor;
            _dateLabel.ForeColor = textColor;
        }

        private void _pvNumeric_ValueChanged(object sender, EventArgs e)
        {
            ValueChanged(this, e);
        }
    }
}