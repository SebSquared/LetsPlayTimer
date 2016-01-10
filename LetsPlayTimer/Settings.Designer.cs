namespace LetsPlayTimer
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.LabelStartButton = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.GroupBindings = new System.Windows.Forms.GroupBox();
            this.LabelStopButton = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.GroupVariables = new System.Windows.Forms.GroupBox();
            this.LabelSeconds = new System.Windows.Forms.Label();
            this.LabelMinutes = new System.Windows.Forms.Label();
            this.SecNUD = new System.Windows.Forms.NumericUpDown();
            this.MinNUD = new System.Windows.Forms.NumericUpDown();
            this.RedLabel = new System.Windows.Forms.Label();
            this.LabelCredits = new System.Windows.Forms.Label();
            this.GroupBindings.SuspendLayout();
            this.GroupVariables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelStartButton
            // 
            this.LabelStartButton.AutoSize = true;
            this.LabelStartButton.Location = new System.Drawing.Point(15, 28);
            this.LabelStartButton.Name = "LabelStartButton";
            this.LabelStartButton.Size = new System.Drawing.Size(50, 13);
            this.LabelStartButton.TabIndex = 0;
            this.LabelStartButton.Text = "Start Key";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(90, 23);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(117, 23);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Waiting...";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            this.StartButton.Leave += new System.EventHandler(this.StartButton_Leave);
            // 
            // GroupBindings
            // 
            this.GroupBindings.Controls.Add(this.LabelStopButton);
            this.GroupBindings.Controls.Add(this.StopButton);
            this.GroupBindings.Controls.Add(this.LabelStartButton);
            this.GroupBindings.Controls.Add(this.StartButton);
            this.GroupBindings.Location = new System.Drawing.Point(12, 12);
            this.GroupBindings.Name = "GroupBindings";
            this.GroupBindings.Size = new System.Drawing.Size(324, 90);
            this.GroupBindings.TabIndex = 2;
            this.GroupBindings.TabStop = false;
            this.GroupBindings.Text = "Button Bindings";
            // 
            // LabelStopButton
            // 
            this.LabelStopButton.AutoSize = true;
            this.LabelStopButton.Location = new System.Drawing.Point(15, 57);
            this.LabelStopButton.Name = "LabelStopButton";
            this.LabelStopButton.Size = new System.Drawing.Size(50, 13);
            this.LabelStopButton.TabIndex = 2;
            this.LabelStopButton.Text = "Stop Key";
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(90, 52);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(117, 23);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "Waiting...";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            this.StopButton.Leave += new System.EventHandler(this.StopButton_Leave);
            // 
            // CButton
            // 
            this.CButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CButton.Location = new System.Drawing.Point(249, 178);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(87, 23);
            this.CButton.TabIndex = 3;
            this.CButton.Text = "Cancel";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(156, 178);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(87, 23);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // GroupVariables
            // 
            this.GroupVariables.Controls.Add(this.LabelSeconds);
            this.GroupVariables.Controls.Add(this.LabelMinutes);
            this.GroupVariables.Controls.Add(this.SecNUD);
            this.GroupVariables.Controls.Add(this.MinNUD);
            this.GroupVariables.Controls.Add(this.RedLabel);
            this.GroupVariables.Location = new System.Drawing.Point(12, 108);
            this.GroupVariables.Name = "GroupVariables";
            this.GroupVariables.Size = new System.Drawing.Size(324, 64);
            this.GroupVariables.TabIndex = 4;
            this.GroupVariables.TabStop = false;
            this.GroupVariables.Text = "Variables";
            // 
            // LabelSeconds
            // 
            this.LabelSeconds.AutoSize = true;
            this.LabelSeconds.Location = new System.Drawing.Point(216, 24);
            this.LabelSeconds.Name = "LabelSeconds";
            this.LabelSeconds.Size = new System.Drawing.Size(26, 13);
            this.LabelSeconds.TabIndex = 2;
            this.LabelSeconds.Text = "Sec";
            // 
            // LabelMinutes
            // 
            this.LabelMinutes.AutoSize = true;
            this.LabelMinutes.Location = new System.Drawing.Point(138, 24);
            this.LabelMinutes.Name = "LabelMinutes";
            this.LabelMinutes.Size = new System.Drawing.Size(24, 13);
            this.LabelMinutes.TabIndex = 2;
            this.LabelMinutes.Text = "Min";
            // 
            // SecNUD
            // 
            this.SecNUD.Location = new System.Drawing.Point(168, 22);
            this.SecNUD.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.SecNUD.Name = "SecNUD";
            this.SecNUD.Size = new System.Drawing.Size(42, 20);
            this.SecNUD.TabIndex = 1;
            this.SecNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SecNUD.ValueChanged += new System.EventHandler(this.RedTimeNUDs_ValueChanged);
            // 
            // MinNUD
            // 
            this.MinNUD.Location = new System.Drawing.Point(90, 22);
            this.MinNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MinNUD.Name = "MinNUD";
            this.MinNUD.Size = new System.Drawing.Size(42, 20);
            this.MinNUD.TabIndex = 1;
            this.MinNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinNUD.ValueChanged += new System.EventHandler(this.RedTimeNUDs_ValueChanged);
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.Location = new System.Drawing.Point(15, 24);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(53, 13);
            this.RedLabel.TabIndex = 0;
            this.RedLabel.Text = "Red Time";
            // 
            // LabelCredits
            // 
            this.LabelCredits.AutoSize = true;
            this.LabelCredits.Location = new System.Drawing.Point(12, 183);
            this.LabelCredits.Name = "LabelCredits";
            this.LabelCredits.Size = new System.Drawing.Size(82, 13);
            this.LabelCredits.TabIndex = 5;
            this.LabelCredits.Text = "Icon by flaticon!";
            // 
            // Settings
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CButton;
            this.ClientSize = new System.Drawing.Size(348, 213);
            this.Controls.Add(this.LabelCredits);
            this.Controls.Add(this.GroupVariables);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CButton);
            this.Controls.Add(this.GroupBindings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.GroupBindings.ResumeLayout(false);
            this.GroupBindings.PerformLayout();
            this.GroupVariables.ResumeLayout(false);
            this.GroupVariables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelStartButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.GroupBox GroupBindings;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label LabelStopButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.GroupBox GroupVariables;
        private System.Windows.Forms.NumericUpDown MinNUD;
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.Label LabelMinutes;
        private System.Windows.Forms.Label LabelSeconds;
        private System.Windows.Forms.NumericUpDown SecNUD;
        private System.Windows.Forms.Label LabelCredits;
    }
}