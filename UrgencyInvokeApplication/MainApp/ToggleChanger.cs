using System;
using System.Windows.Forms;

namespace MainApp
{
    public class ToggleChanger : IDisposable
    {
        private readonly CheckBox[] _controls;

        public ToggleChanger(CheckBox[] controls)
        {
            _controls = controls;
            SubScribe();
        }

        private void ChangeToggle(object sender, EventArgs e)
        {
            var senderCheckBox = (CheckBox) sender;
            foreach (var control in _controls)
            {
                control.Checked = senderCheckBox.Equals(control);
            }
        }

        private void SubScribe()
        {
            foreach (var control in _controls)
            {
                control.Click += ChangeToggle;
            }
        }

        private void StopSubScribe()
        {
            foreach (var control in _controls)
            {
                control.Click -= ChangeToggle;
            }
        }

        public void Dispose()
        {
            StopSubScribe();
        }
    }
}