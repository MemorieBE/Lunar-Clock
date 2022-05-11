
namespace LunarClock
{
    partial class CalibrationForm
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
            this.lunarComboBox = new System.Windows.Forms.ComboBox();
            this.lunarDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lunarTimePicker = new System.Windows.Forms.DateTimePicker();
            this.calibrationButton = new System.Windows.Forms.Button();
            this.calText1 = new System.Windows.Forms.Label();
            this.calText2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.moonDisplayImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.moonDisplayImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lunarComboBox
            // 
            this.lunarComboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lunarComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lunarComboBox.Font = new System.Drawing.Font("Kotta One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunarComboBox.FormattingEnabled = true;
            this.lunarComboBox.Items.AddRange(new object[] {
            "New Moon",
            "First Quater",
            "Full Moon",
            "Third Quater"});
            this.lunarComboBox.Location = new System.Drawing.Point(176, 282);
            this.lunarComboBox.Name = "lunarComboBox";
            this.lunarComboBox.Size = new System.Drawing.Size(217, 30);
            this.lunarComboBox.TabIndex = 1;
            this.lunarComboBox.SelectedIndexChanged += new System.EventHandler(this.lunarComboBox_SelectedIndexChanged);
            // 
            // lunarDatePicker
            // 
            this.lunarDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lunarDatePicker.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunarDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lunarDatePicker.Location = new System.Drawing.Point(488, 280);
            this.lunarDatePicker.Name = "lunarDatePicker";
            this.lunarDatePicker.Size = new System.Drawing.Size(129, 33);
            this.lunarDatePicker.TabIndex = 3;
            // 
            // lunarTimePicker
            // 
            this.lunarTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lunarTimePicker.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunarTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.lunarTimePicker.Location = new System.Drawing.Point(623, 280);
            this.lunarTimePicker.Name = "lunarTimePicker";
            this.lunarTimePicker.ShowUpDown = true;
            this.lunarTimePicker.Size = new System.Drawing.Size(127, 33);
            this.lunarTimePicker.TabIndex = 4;
            this.lunarTimePicker.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // calibrationButton
            // 
            this.calibrationButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.calibrationButton.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calibrationButton.Location = new System.Drawing.Point(300, 355);
            this.calibrationButton.Name = "calibrationButton";
            this.calibrationButton.Size = new System.Drawing.Size(200, 45);
            this.calibrationButton.TabIndex = 5;
            this.calibrationButton.Text = "Calibrate";
            this.calibrationButton.UseVisualStyleBackColor = true;
            this.calibrationButton.Click += new System.EventHandler(this.calibrationButton_Click);
            // 
            // calText1
            // 
            this.calText1.AutoSize = true;
            this.calText1.BackColor = System.Drawing.Color.Transparent;
            this.calText1.Font = new System.Drawing.Font("Kotta One", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calText1.Location = new System.Drawing.Point(47, 280);
            this.calText1.Name = "calText1";
            this.calText1.Size = new System.Drawing.Size(123, 33);
            this.calText1.TabIndex = 11;
            this.calText1.Text = "The next";
            // 
            // calText2
            // 
            this.calText2.AutoSize = true;
            this.calText2.BackColor = System.Drawing.Color.Transparent;
            this.calText2.Font = new System.Drawing.Font("Kotta One", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calText2.Location = new System.Drawing.Point(399, 280);
            this.calText2.Name = "calText2";
            this.calText2.Size = new System.Drawing.Size(83, 33);
            this.calText2.TabIndex = 12;
            this.calText2.Text = "is on:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Kotta One", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "Please calibrate the lunar cycle.";
            // 
            // moonDisplayImage
            // 
            this.moonDisplayImage.BackColor = System.Drawing.Color.Transparent;
            this.moonDisplayImage.BackgroundImage = global::LunarClock.Properties.Resources.New_Moon;
            this.moonDisplayImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moonDisplayImage.Location = new System.Drawing.Point(300, 69);
            this.moonDisplayImage.Name = "moonDisplayImage";
            this.moonDisplayImage.Size = new System.Drawing.Size(200, 200);
            this.moonDisplayImage.TabIndex = 14;
            this.moonDisplayImage.TabStop = false;
            // 
            // CalibrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::LunarClock.Properties.Resources.Stars_Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moonDisplayImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lunarTimePicker);
            this.Controls.Add(this.lunarComboBox);
            this.Controls.Add(this.lunarDatePicker);
            this.Controls.Add(this.calText2);
            this.Controls.Add(this.calText1);
            this.Controls.Add(this.calibrationButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CalibrationForm";
            this.Text = "Calibrate";
            this.Load += new System.EventHandler(this.CalibrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moonDisplayImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox lunarComboBox;
        private System.Windows.Forms.DateTimePicker lunarDatePicker;
        private System.Windows.Forms.DateTimePicker lunarTimePicker;
        private System.Windows.Forms.Button calibrationButton;
        private System.Windows.Forms.Label calText1;
        private System.Windows.Forms.Label calText2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox moonDisplayImage;
    }
}