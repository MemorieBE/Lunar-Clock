
namespace LunarClock
{
    partial class ClockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClockForm));
            this.timeText = new System.Windows.Forms.Label();
            this.recalibrationButton = new System.Windows.Forms.Button();
            this.lunarPhaseText = new System.Windows.Forms.Label();
            this.lunarLuminanceText = new System.Windows.Forms.Label();
            this.sourceText = new System.Windows.Forms.Label();
            this.lunarCyclePB = new System.Windows.Forms.PictureBox();
            this.sourceLink = new System.Windows.Forms.LinkLabel();
            this.moonDescriptionText = new System.Windows.Forms.Label();
            this.moonTitleText = new System.Windows.Forms.Label();
            this.lunarPeakTimeText = new System.Windows.Forms.Label();
            this.lunarPeakDateText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lunarCyclePB)).BeginInit();
            this.SuspendLayout();
            // 
            // timeText
            // 
            this.timeText.BackColor = System.Drawing.Color.Transparent;
            this.timeText.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeText.Location = new System.Drawing.Point(358, 452);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(288, 99);
            this.timeText.TabIndex = 0;
            this.timeText.Text = "12:00:00 AM\r\n1 January 2000";
            this.timeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recalibrationButton
            // 
            this.recalibrationButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.recalibrationButton.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recalibrationButton.Location = new System.Drawing.Point(788, 503);
            this.recalibrationButton.Name = "recalibrationButton";
            this.recalibrationButton.Size = new System.Drawing.Size(200, 45);
            this.recalibrationButton.TabIndex = 6;
            this.recalibrationButton.Text = "Recalibrate";
            this.recalibrationButton.UseVisualStyleBackColor = true;
            this.recalibrationButton.Click += new System.EventHandler(this.recalibrationButton_Click);
            // 
            // lunarPhaseText
            // 
            this.lunarPhaseText.BackColor = System.Drawing.Color.Transparent;
            this.lunarPhaseText.Font = new System.Drawing.Font("Kotta One", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunarPhaseText.Location = new System.Drawing.Point(295, 300);
            this.lunarPhaseText.Name = "lunarPhaseText";
            this.lunarPhaseText.Size = new System.Drawing.Size(415, 65);
            this.lunarPhaseText.TabIndex = 7;
            this.lunarPhaseText.Text = "New Moon";
            this.lunarPhaseText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lunarLuminanceText
            // 
            this.lunarLuminanceText.AutoSize = true;
            this.lunarLuminanceText.BackColor = System.Drawing.Color.Transparent;
            this.lunarLuminanceText.Font = new System.Drawing.Font("Kotta One", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunarLuminanceText.Location = new System.Drawing.Point(359, 365);
            this.lunarLuminanceText.Name = "lunarLuminanceText";
            this.lunarLuminanceText.Size = new System.Drawing.Size(190, 29);
            this.lunarLuminanceText.TabIndex = 8;
            this.lunarLuminanceText.Text = "Luminance: 0%";
            this.lunarLuminanceText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sourceText
            // 
            this.sourceText.AutoSize = true;
            this.sourceText.BackColor = System.Drawing.Color.Transparent;
            this.sourceText.Cursor = System.Windows.Forms.Cursors.Default;
            this.sourceText.Location = new System.Drawing.Point(12, 525);
            this.sourceText.Name = "sourceText";
            this.sourceText.Size = new System.Drawing.Size(44, 13);
            this.sourceText.TabIndex = 9;
            this.sourceText.Text = "Source:";
            // 
            // lunarCyclePB
            // 
            this.lunarCyclePB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lunarCyclePB.BackColor = System.Drawing.Color.Transparent;
            this.lunarCyclePB.BackgroundImage = global::LunarClock.Properties.Resources.Lunar_Cycle;
            this.lunarCyclePB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lunarCyclePB.Location = new System.Drawing.Point(180, -400);
            this.lunarCyclePB.Name = "lunarCyclePB";
            this.lunarCyclePB.Size = new System.Drawing.Size(640, 640);
            this.lunarCyclePB.TabIndex = 0;
            this.lunarCyclePB.TabStop = false;
            // 
            // sourceLink
            // 
            this.sourceLink.ActiveLinkColor = System.Drawing.Color.Blue;
            this.sourceLink.AutoSize = true;
            this.sourceLink.BackColor = System.Drawing.Color.Transparent;
            this.sourceLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sourceLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sourceLink.Location = new System.Drawing.Point(12, 538);
            this.sourceLink.Name = "sourceLink";
            this.sourceLink.Size = new System.Drawing.Size(226, 13);
            this.sourceLink.TabIndex = 10;
            this.sourceLink.TabStop = true;
            this.sourceLink.Text = "https://www.timeanddate.com/moon/phases/";
            this.sourceLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sourceLink_LinkClicked);
            // 
            // moonDescriptionText
            // 
            this.moonDescriptionText.AutoSize = true;
            this.moonDescriptionText.BackColor = System.Drawing.Color.Transparent;
            this.moonDescriptionText.Font = new System.Drawing.Font("Kotta One", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moonDescriptionText.ForeColor = System.Drawing.Color.Black;
            this.moonDescriptionText.Location = new System.Drawing.Point(10, 167);
            this.moonDescriptionText.Name = "moonDescriptionText";
            this.moonDescriptionText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.moonDescriptionText.Size = new System.Drawing.Size(317, 338);
            this.moonDescriptionText.TabIndex = 11;
            this.moonDescriptionText.Text = resources.GetString("moonDescriptionText.Text");
            // 
            // moonTitleText
            // 
            this.moonTitleText.AutoSize = true;
            this.moonTitleText.BackColor = System.Drawing.Color.Transparent;
            this.moonTitleText.Font = new System.Drawing.Font("Kotta One", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moonTitleText.ForeColor = System.Drawing.Color.Black;
            this.moonTitleText.Location = new System.Drawing.Point(12, 124);
            this.moonTitleText.Name = "moonTitleText";
            this.moonTitleText.Size = new System.Drawing.Size(145, 33);
            this.moonTitleText.TabIndex = 12;
            this.moonTitleText.Text = "New Moon";
            // 
            // lunarPeakTimeText
            // 
            this.lunarPeakTimeText.AutoSize = true;
            this.lunarPeakTimeText.BackColor = System.Drawing.Color.Transparent;
            this.lunarPeakTimeText.Font = new System.Drawing.Font("Kotta One", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunarPeakTimeText.Location = new System.Drawing.Point(359, 394);
            this.lunarPeakTimeText.Name = "lunarPeakTimeText";
            this.lunarPeakTimeText.Size = new System.Drawing.Size(242, 29);
            this.lunarPeakTimeText.TabIndex = 13;
            this.lunarPeakTimeText.Text = "Peak Time: 12:00AM";
            // 
            // lunarPeakDateText
            // 
            this.lunarPeakDateText.AutoSize = true;
            this.lunarPeakDateText.BackColor = System.Drawing.Color.Transparent;
            this.lunarPeakDateText.Font = new System.Drawing.Font("Kotta One", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunarPeakDateText.Location = new System.Drawing.Point(359, 423);
            this.lunarPeakDateText.Name = "lunarPeakDateText";
            this.lunarPeakDateText.Size = new System.Drawing.Size(241, 29);
            this.lunarPeakDateText.TabIndex = 16;
            this.lunarPeakDateText.Text = "Peak Date: 1/1/2000";
            // 
            // ClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 560);
            this.Controls.Add(this.lunarPeakDateText);
            this.Controls.Add(this.lunarPeakTimeText);
            this.Controls.Add(this.moonDescriptionText);
            this.Controls.Add(this.moonTitleText);
            this.Controls.Add(this.lunarCyclePB);
            this.Controls.Add(this.sourceLink);
            this.Controls.Add(this.sourceText);
            this.Controls.Add(this.lunarLuminanceText);
            this.Controls.Add(this.lunarPhaseText);
            this.Controls.Add(this.recalibrationButton);
            this.Controls.Add(this.timeText);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClockForm";
            this.Text = "Lunar Clock";
            this.Load += new System.EventHandler(this.ClockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lunarCyclePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeText;
        private System.Windows.Forms.PictureBox lunarCyclePB;
        private System.Windows.Forms.Button recalibrationButton;
        private System.Windows.Forms.Label lunarPhaseText;
        private System.Windows.Forms.Label lunarLuminanceText;
        private System.Windows.Forms.Label sourceText;
        private System.Windows.Forms.LinkLabel sourceLink;
        private System.Windows.Forms.Label moonDescriptionText;
        private System.Windows.Forms.Label moonTitleText;
        private System.Windows.Forms.Label lunarPeakTimeText;
        private System.Windows.Forms.Label lunarPeakDateText;
    }
}

