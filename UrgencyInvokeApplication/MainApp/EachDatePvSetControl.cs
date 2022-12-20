using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MainApp
{
    public partial class EachDatePvSetControl : UserControl
    {
        public EachDatePvSetControl()
        {
            InitializeComponent();
            IDictionary<DayOfWeek, DateAndNumericControl> dateAndNumericControls =
                new Dictionary<DayOfWeek, DateAndNumericControl>()
                {
                    {DayOfWeek.Sunday, _sunDayControl},
                    {DayOfWeek.Monday, _mondayControl},
                    {DayOfWeek.Tuesday, _tuesdayControl},
                    {DayOfWeek.Wednesday, _wednesdayControl},
                    {DayOfWeek.Thursday, _thursdayControl},
                    {DayOfWeek.Friday, _fridayControl},
                    {DayOfWeek.Saturday, _saturdayControl}
                };
            foreach (var kv in dateAndNumericControls)
            {
                kv.Value.Dock = DockStyle.Fill;
                kv.Value.Set(kv.Key, Color.Black);
            }

            dateAndNumericControls[DayOfWeek.Saturday].Set(DayOfWeek.Saturday, Color.Blue);
            dateAndNumericControls[DayOfWeek.Sunday].Set(DayOfWeek.Sunday, Color.Red);
        }
    }
}