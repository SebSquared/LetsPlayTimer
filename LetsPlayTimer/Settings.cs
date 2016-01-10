using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LetsPlayTimer
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private Keys startKey;
        private Keys stopKey;
        private int redTime; 

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.StartButton.Text = "Waiting...";
            this.StartButton.ForeColor = Color.Red;
            this.StartButton.KeyDown += StartButton_KeyDown;
        }

        void StartButton_KeyDown(object sender, KeyEventArgs e)
        {
            this.StartButton.Text = e.KeyCode.ToString();
            this.StartButton.ForeColor = Color.Black;

            this.StartButton.KeyDown -= StartButton_KeyDown;
            this.startKey = e.KeyCode;
        }

        private void StartButton_Leave(object sender, EventArgs e)
        {
            this.StartButton.Text = this.startKey.ToString();
            this.StartButton.ForeColor = Color.Black;
            this.StartButton.KeyDown -= StartButton_KeyDown; 
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            this.StartButton.Text = Properties.Settings.Default.StartKey.ToString();
            this.StopButton.Text = Properties.Settings.Default.StopKey.ToString();

            this.MinNUD.Value = Properties.Settings.Default.RedTime / 60;
            this.SecNUD.Value = Properties.Settings.Default.RedTime % 60;

            this.startKey = Properties.Settings.Default.StartKey;
            this.stopKey = Properties.Settings.Default.StopKey;
            this.redTime = Properties.Settings.Default.RedTime;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            this.StopButton.Text = "Waiting...";
            this.StopButton.ForeColor = Color.Red;
            this.StopButton.KeyDown += StopButton_KeyDown;
        }

        void StopButton_KeyDown(object sender, KeyEventArgs e)
        {
            this.StopButton.Text = e.KeyCode.ToString();
            this.StopButton.ForeColor = Color.Black;

            this.StopButton.KeyDown -= StopButton_KeyDown;
            this.stopKey = e.KeyCode;
        }

        private void StopButton_Leave(object sender, EventArgs e)
        {
            this.StopButton.Text = this.stopKey.ToString();
            this.StopButton.ForeColor = Color.Black;
            this.StopButton.KeyDown -= StopButton_KeyDown;
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.StartKey = this.startKey;
            Properties.Settings.Default.StopKey = this.stopKey;
            Properties.Settings.Default.RedTime = this.redTime;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void RedTimeNUDs_ValueChanged(object sender, EventArgs e)
        {
            this.redTime = (int) MinNUD.Value * 60 + (int) SecNUD.Value;
            // TODO: this.timeGoal = int.Parse(MinNUD.Value.ToString()); // Nobody saw this!
        }

    }
}
