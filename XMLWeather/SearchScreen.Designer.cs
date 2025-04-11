namespace XMLWeather
{
    partial class SearchScreen
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
            this.searchCityBar = new System.Windows.Forms.TextBox();
            this.addCity = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.searchCountryBar = new System.Windows.Forms.TextBox();
            this.cityOutput = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchCityBar
            // 
            this.searchCityBar.Location = new System.Drawing.Point(42, 41);
            this.searchCityBar.Name = "searchCityBar";
            this.searchCityBar.Size = new System.Drawing.Size(248, 22);
            this.searchCityBar.TabIndex = 72;
            // 
            // addCity
            // 
            this.addCity.Location = new System.Drawing.Point(128, 114);
            this.addCity.Name = "addCity";
            this.addCity.Size = new System.Drawing.Size(75, 23);
            this.addCity.TabIndex = 73;
            this.addCity.Text = "Add";
            this.addCity.UseVisualStyleBackColor = true;
            this.addCity.Click += new System.EventHandler(this.addCity_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(128, 143);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 74;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // searchCountryBar
            // 
            this.searchCountryBar.Location = new System.Drawing.Point(42, 69);
            this.searchCountryBar.Name = "searchCountryBar";
            this.searchCountryBar.Size = new System.Drawing.Size(248, 22);
            this.searchCountryBar.TabIndex = 75;
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(4, 198);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(325, 200);
            this.cityOutput.TabIndex = 76;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorLabel
            // 
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.White;
            this.errorLabel.Location = new System.Drawing.Point(4, 398);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(325, 40);
            this.errorLabel.TabIndex = 77;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.searchCountryBar);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addCity);
            this.Controls.Add(this.searchCityBar);
            this.Name = "SearchScreen";
            this.Size = new System.Drawing.Size(333, 492);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchCityBar;
        private System.Windows.Forms.Button addCity;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox searchCountryBar;
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label errorLabel;
    }
}
