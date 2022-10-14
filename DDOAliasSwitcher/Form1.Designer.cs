namespace DDOAliasSwitcher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.locTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.locButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.raidDayComboBox = new System.Windows.Forms.ComboBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.defaultFileLocButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.defaultFileTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // locTextBox
            // 
            this.locTextBox.Location = new System.Drawing.Point(133, 91);
            this.locTextBox.Name = "locTextBox";
            this.locTextBox.Size = new System.Drawing.Size(199, 23);
            this.locTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Layout File Location:";
            // 
            // locButton
            // 
            this.locButton.Location = new System.Drawing.Point(338, 90);
            this.locButton.Name = "locButton";
            this.locButton.Size = new System.Drawing.Size(33, 23);
            this.locButton.TabIndex = 13;
            this.locButton.Text = "...";
            this.locButton.UseVisualStyleBackColor = true;
            this.locButton.Click += new System.EventHandler(this.locButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.SystemColors.Menu;
            this.helpButton.Location = new System.Drawing.Point(299, 12);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 23);
            this.helpButton.TabIndex = 14;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // raidDayComboBox
            // 
            this.raidDayComboBox.FormattingEnabled = true;
            this.raidDayComboBox.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "SaturdayAM1",
            "SaturdayAM2",
            "SaturdayPM",
            "Sunday",
            "-----",
            "MyDefaultFile"});
            this.raidDayComboBox.Location = new System.Drawing.Point(102, 145);
            this.raidDayComboBox.Name = "raidDayComboBox";
            this.raidDayComboBox.Size = new System.Drawing.Size(128, 23);
            this.raidDayComboBox.TabIndex = 16;
            this.raidDayComboBox.Text = "-- Select Raid Day --";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(236, 145);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(43, 23);
            this.GoButton.TabIndex = 17;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // defaultFileLocButton
            // 
            this.defaultFileLocButton.Location = new System.Drawing.Point(337, 199);
            this.defaultFileLocButton.Name = "defaultFileLocButton";
            this.defaultFileLocButton.Size = new System.Drawing.Size(33, 23);
            this.defaultFileLocButton.TabIndex = 20;
            this.defaultFileLocButton.Text = "...";
            this.defaultFileLocButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Default File Location:";
            // 
            // defaultFileTextBox
            // 
            this.defaultFileTextBox.Location = new System.Drawing.Point(132, 200);
            this.defaultFileTextBox.Name = "defaultFileTextBox";
            this.defaultFileTextBox.Size = new System.Drawing.Size(199, 23);
            this.defaultFileTextBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 278);
            this.Controls.Add(this.defaultFileLocButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.defaultFileTextBox);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.raidDayComboBox);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.locButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locTextBox);
            this.Name = "Form1";
            this.Text = "DDO Layout File Switcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox locTextBox;
        private Label label1;
        private Button locButton;
        private Button helpButton;
        private ComboBox raidDayComboBox;
        private Button GoButton;
        private Button defaultFileLocButton;
        private Label label2;
        private TextBox defaultFileTextBox;
    }
}