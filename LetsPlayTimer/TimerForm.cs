using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LetsPlayTimer
{
    public partial class TimerForm : Form
    {

        private globalKeyboardHook hook = new globalKeyboardHook();

        public TimerForm()
        {
            InitializeComponent();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hookKeys(true);

            Settings sett = new Settings();
            sett.ShowDialog();

            hookKeys(false);
        }

        private void hookKeys(bool unhook)
        {
            if (!unhook)
            {
                hook.HookedKeys.Add(Properties.Settings.Default.StartKey);
                hook.HookedKeys.Add(Properties.Settings.Default.StopKey);
                hook.KeyDown += hook_KeyDown;
            }
            else
            {
                hook.HookedKeys.Clear();
                hook.KeyDown -= hook_KeyDown;
            }

        }

        void hook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Properties.Settings.Default.StartKey)
            {
                // Start Key Down
            }
            else if (e.KeyCode == Properties.Settings.Default.StopKey)
            {
                // Stop Key Down
            }
        }

    }
}
