using System;
using System.Windows.Forms;
using MainApp.RemainTimer;
using MainApplication;

namespace UrgencyInvokerTest
{
    public partial class TestForm : Form
    {
        private readonly RemainingTimerControl _remainingTimerControl;

        public TestForm()
        {
            InitializeComponent();
            var limitDate = new DateTime(2022, 10, 10);
            _remainingTimerControl = new RemainingTimerControl(new RemainingTimerModel(limitDate));
        }
    }
}