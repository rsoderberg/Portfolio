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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.locTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.locButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.raidDayComboBox = new System.Windows.Forms.ComboBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.defaultFileLocButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.defaultLocTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ahkCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // locTextBox
            // 
            this.locTextBox.Location = new System.Drawing.Point(101, 96);
            this.locTextBox.Name = "locTextBox";
            this.locTextBox.Size = new System.Drawing.Size(231, 23);
            this.locTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Layouts Folder\r\nLocation:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // locButton
            // 
            this.locButton.Location = new System.Drawing.Point(336, 96);
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
            "SkeletonsTalkies",
            "-----",
            "MyDefaultFile"});
            this.raidDayComboBox.Location = new System.Drawing.Point(101, 146);
            this.raidDayComboBox.Name = "raidDayComboBox";
            this.raidDayComboBox.Size = new System.Drawing.Size(159, 23);
            this.raidDayComboBox.TabIndex = 16;
            this.raidDayComboBox.Text = "-- Select Layout Setting --";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(264, 146);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(43, 23);
            this.GoButton.TabIndex = 17;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // defaultFileLocButton
            // 
            this.defaultFileLocButton.Location = new System.Drawing.Point(335, 196);
            this.defaultFileLocButton.Name = "defaultFileLocButton";
            this.defaultFileLocButton.Size = new System.Drawing.Size(33, 23);
            this.defaultFileLocButton.TabIndex = 20;
            this.defaultFileLocButton.Text = "...";
            this.defaultFileLocButton.UseVisualStyleBackColor = true;
            this.defaultFileLocButton.Click += new System.EventHandler(this.defaultFileLocButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 30);
            this.label2.TabIndex = 19;
            this.label2.Text = "Default File\r\nLocation:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // defaultLocTextBox
            // 
            this.defaultLocTextBox.Location = new System.Drawing.Point(101, 196);
            this.defaultLocTextBox.Name = "defaultLocTextBox";
            this.defaultLocTextBox.Size = new System.Drawing.Size(230, 23);
            this.defaultLocTextBox.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // ahkCheckbox
            // 
            this.ahkCheckbox.AutoSize = true;
            this.ahkCheckbox.Checked = true;
            this.ahkCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ahkCheckbox.Location = new System.Drawing.Point(266, 245);
            this.ahkCheckbox.Name = "ahkCheckbox";
            this.ahkCheckbox.Size = new System.Drawing.Size(107, 19);
            this.ahkCheckbox.TabIndex = 23;
            this.ahkCheckbox.Text = "Run AHK Script";
            this.ahkCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 278);
            this.Controls.Add(this.ahkCheckbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.defaultFileLocButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.defaultLocTextBox);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.raidDayComboBox);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.locButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DDO Layout File Switcher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private TextBox defaultLocTextBox;
        private PictureBox pictureBox1;
        private CheckBox ahkCheckbox;
    }
}