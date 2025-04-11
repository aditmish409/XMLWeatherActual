namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.currentCityOutput = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.todayDateLabel = new System.Windows.Forms.Label();
            this.currentTempOutput = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currentCityOutput
            // 
            this.currentCityOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentCityOutput.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentCityOutput.ForeColor = System.Drawing.Color.White;
            this.currentCityOutput.Location = new System.Drawing.Point(4, 99);
            this.currentCityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentCityOutput.Name = "currentCityOutput";
            this.currentCityOutput.Size = new System.Drawing.Size(325, 28);
            this.currentCityOutput.TabIndex = 22;
            this.currentCityOutput.Text = "City";
            this.currentCityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(35, 430);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(32, 16);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "Max";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(39, 370);
            this.minLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(28, 16);
            this.minLabel.TabIndex = 29;
            this.minLabel.Text = "Min";
            // 
            // tempLabel
            // 
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(29, 307);
            this.tempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(136, 23);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "Current Temperature";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 34);
            this.label3.TabIndex = 40;
            this.label3.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(188, 18);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(110, 34);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 33);
            this.label5.TabIndex = 42;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // todayDateLabel
            // 
            this.todayDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.todayDateLabel.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayDateLabel.ForeColor = System.Drawing.Color.White;
            this.todayDateLabel.Location = new System.Drawing.Point(4, 143);
            this.todayDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.todayDateLabel.Name = "todayDateLabel";
            this.todayDateLabel.Size = new System.Drawing.Size(325, 28);
            this.todayDateLabel.TabIndex = 44;
            this.todayDateLabel.Text = "Date";
            this.todayDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentTempOutput
            // 
            this.currentTempOutput.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTempOutput.ForeColor = System.Drawing.Color.White;
            this.currentTempOutput.Location = new System.Drawing.Point(172, 307);
            this.currentTempOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentTempOutput.Name = "currentTempOutput";
            this.currentTempOutput.Size = new System.Drawing.Size(136, 23);
            this.currentTempOutput.TabIndex = 45;
            // 
            // minOutput
            // 
            this.minOutput.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.ForeColor = System.Drawing.Color.White;
            this.minOutput.Location = new System.Drawing.Point(172, 370);
            this.minOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(136, 23);
            this.minOutput.TabIndex = 46;
            // 
            // maxOutput
            // 
            this.maxOutput.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.ForeColor = System.Drawing.Color.White;
            this.maxOutput.Location = new System.Drawing.Point(172, 430);
            this.maxOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(136, 23);
            this.maxOutput.TabIndex = 47;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.currentTempOutput);
            this.Controls.Add(this.todayDateLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentCityOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(333, 492);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label currentCityOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label todayDateLabel;
        private System.Windows.Forms.Label currentTempOutput;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label maxOutput;
    }
}
