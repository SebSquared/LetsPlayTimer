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
        private int time = 0;

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
            if (e.KeyCode == Properties.Settings.Default.StartKey && !mainTimer.Enabled) // Special case: StartKey = StopKey
            {
                time = 0;
                this.TimerLabel.ForeColor = Color.Black;
                mainTimer.Enabled = true;
            }
            else if (e.KeyCode == Properties.Settings.Default.StopKey)
            {
                mainTimer.Enabled = false;
            }
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            time++;

            if (time < 3600)
            {
                this.TimerLabel.Text = String.Format("{0:00}",(time / 60)) + ":" + 
                    String.Format("{0:00}",(time % 60));
            }
            else
            {
                this.TimerLabel.Text = String.Format("{0:00}",(time / 3600)) + ":" + 
                    String.Format("{0:00}",(time % 3600) / 60) + ":" + 
                    String.Format("{0:00}",(time % 3600) % 60);
            }

            if (time > Properties.Settings.Default.RedTime)
            {
                this.TimerLabel.ForeColor = Color.Red;
            }
            else
            {
                this.TimerLabel.ForeColor = Color.Black;
            }
            
        }

        private void TimerForm_Load(object sender, EventArgs e)
        {
            hookKeys(false);
            this.TimerLabel.ForeColor = Color.Black;
            time = 0;
        }

    }
}
