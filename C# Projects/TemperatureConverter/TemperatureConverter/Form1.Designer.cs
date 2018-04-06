namespace TemperatureConverter
{
    partial class tempConvForm
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
            this.initialBox = new System.Windows.Forms.GroupBox();
            this.resultBox = new System.Windows.Forms.GroupBox();
            this.fahrenInitialRadio = new System.Windows.Forms.RadioButton();
            this.celsiusInitialRadio = new System.Windows.Forms.RadioButton();
            this.kelvinInitialRadio = new System.Windows.Forms.RadioButton();
            this.fahrenResultRadio = new System.Windows.Forms.RadioButton();
            this.celsiusResultRadio = new System.Windows.Forms.RadioButton();
            this.kelvinResultRadio = new System.Windows.Forms.RadioButton();
            this.initialTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.initialBox.SuspendLayout();
            this.resultBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // initialBox
            // 
            this.initialBox.Controls.Add(this.initialTextBox);
            this.initialBox.Controls.Add(this.fahrenInitialRadio);
            this.initialBox.Controls.Add(this.celsiusInitialRadio);
            this.initialBox.Controls.Add(this.kelvinInitialRadio);
            this.initialBox.Location = new System.Drawing.Point(12, 12);
            this.initialBox.Name = "initialBox";
            this.initialBox.Size = new System.Drawing.Size(200, 118);
            this.initialBox.TabIndex = 0;
            this.initialBox.TabStop = false;
            this.initialBox.Text = "Temperature to Convert:";
            // 
            // resultBox
            // 
            this.resultBox.Controls.Add(this.resultLabel);
            this.resultBox.Controls.Add(this.fahrenResultRadio);
            this.resultBox.Controls.Add(this.celsiusResultRadio);
            this.resultBox.Controls.Add(this.kelvinResultRadio);
            this.resultBox.Location = new System.Drawing.Point(233, 12);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(200, 118);
            this.resultBox.TabIndex = 1;
            this.resultBox.TabStop = false;
            this.resultBox.Text = "Result:";
            // 
            // fahrenInitialRadio
            // 
            this.fahrenInitialRadio.AutoSize = true;
            this.fahrenInitialRadio.Checked = true;
            this.fahrenInitialRadio.Location = new System.Drawing.Point(6, 26);
            this.fahrenInitialRadio.Name = "fahrenInitialRadio";
            this.fahrenInitialRadio.Size = new System.Drawing.Size(97, 21);
            this.fahrenInitialRadio.TabIndex = 5;
            this.fahrenInitialRadio.Text = "Fahrenheit";
            this.fahrenInitialRadio.UseVisualStyleBackColor = true;
            // 
            // celsiusInitialRadio
            // 
            this.celsiusInitialRadio.AutoSize = true;
            this.celsiusInitialRadio.Location = new System.Drawing.Point(6, 53);
            this.celsiusInitialRadio.Name = "celsiusInitialRadio";
            this.celsiusInitialRadio.Size = new System.Drawing.Size(74, 21);
            this.celsiusInitialRadio.TabIndex = 5;
            this.celsiusInitialRadio.Text = "Celsius";
            this.celsiusInitialRadio.UseVisualStyleBackColor = true;
            // 
            // kelvinInitialRadio
            // 
            this.kelvinInitialRadio.AutoSize = true;
            this.kelvinInitialRadio.Location = new System.Drawing.Point(6, 80);
            this.kelvinInitialRadio.Name = "kelvinInitialRadio";
            this.kelvinInitialRadio.Size = new System.Drawing.Size(67, 21);
            this.kelvinInitialRadio.TabIndex = 5;
            this.kelvinInitialRadio.Text = "Kelvin";
            this.kelvinInitialRadio.UseVisualStyleBackColor = true;
            // 
            // fahrenResultRadio
            // 
            this.fahrenResultRadio.AutoSize = true;
            this.fahrenResultRadio.Location = new System.Drawing.Point(6, 26);
            this.fahrenResultRadio.Name = "fahrenResultRadio";
            this.fahrenResultRadio.Size = new System.Drawing.Size(97, 21);
            this.fahrenResultRadio.TabIndex = 5;
            this.fahrenResultRadio.Text = "Fahrenheit";
            this.fahrenResultRadio.UseVisualStyleBackColor = true;
            // 
            // celsiusResultRadio
            // 
            this.celsiusResultRadio.AutoSize = true;
            this.celsiusResultRadio.Checked = true;
            this.celsiusResultRadio.Location = new System.Drawing.Point(6, 53);
            this.celsiusResultRadio.Name = "celsiusResultRadio";
            this.celsiusResultRadio.Size = new System.Drawing.Size(74, 21);
            this.celsiusResultRadio.TabIndex = 5;
            this.celsiusResultRadio.Text = "Celsius";
            this.celsiusResultRadio.UseVisualStyleBackColor = true;
            // 
            // kelvinResultRadio
            // 
            this.kelvinResultRadio.AutoSize = true;
            this.kelvinResultRadio.Location = new System.Drawing.Point(6, 80);
            this.kelvinResultRadio.Name = "kelvinResultRadio";
            this.kelvinResultRadio.Size = new System.Drawing.Size(67, 21);
            this.kelvinResultRadio.TabIndex = 5;
            this.kelvinResultRadio.Text = "Kelvin";
            this.kelvinResultRadio.UseVisualStyleBackColor = true;
            // 
            // initialTextBox
            // 
            this.initialTextBox.Location = new System.Drawing.Point(125, 53);
            this.initialTextBox.Name = "initialTextBox";
            this.initialTextBox.Size = new System.Drawing.Size(57, 22);
            this.initialTextBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(118, 136);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(111, 39);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(235, 140);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(84, 31);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(139, 55);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 17);
            this.resultLabel.TabIndex = 6;
            // 
            // tempConvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 181);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.initialBox);
            this.Name = "tempConvForm";
            this.Text = "Convert Temperatures";
            this.initialBox.ResumeLayout(false);
            this.initialBox.PerformLayout();
            this.resultBox.ResumeLayout(false);
            this.resultBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox initialBox;
        private System.Windows.Forms.TextBox initialTextBox;
        private System.Windows.Forms.RadioButton fahrenInitialRadio;
        private System.Windows.Forms.RadioButton celsiusInitialRadio;
        private System.Windows.Forms.RadioButton kelvinInitialRadio;
        private System.Windows.Forms.GroupBox resultBox;
        private System.Windows.Forms.RadioButton fahrenResultRadio;
        private System.Windows.Forms.RadioButton celsiusResultRadio;
        private System.Windows.Forms.RadioButton kelvinResultRadio;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

