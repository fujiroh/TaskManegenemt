using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainApp
{
    public partial class DateAndNumericControl : UserControl
    {
        private double _value;
        public DayOfWeek Day { get; set; } 
        public Color TextColor { get; set; } = DefaultForeColor;
        public double Value => _value;

        public DateAndNumericControl()
        {
            InitializeComponent();
        }

        public void Set(DayOfWeek dayOfWeek,Color textColor)
        {
            Day = dayOfWeek;
            _dateLabel.Text = dayOfWeek.ToString();
            TextColor = textColor;
            _dateLabel.ForeColor = textColor;
        }
        
        private void _valueText_TextChanged(object sender, EventArgs e)
        {
            Double.TryParse(_valueText.Text, out _value);
        }
    }
}