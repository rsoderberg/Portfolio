namespace RSoderbergFinalProject
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eButton = new System.Windows.Forms.Button();
            this.BButton = new System.Windows.Forms.Button();
            this.GButton = new System.Windows.Forms.Button();
            this.DButton = new System.Windows.Forms.Button();
            this.AButton = new System.Windows.Forms.Button();
            this.bigEButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bigEButton);
            this.groupBox2.Controls.Add(this.AButton);
            this.groupBox2.Controls.Add(this.DButton);
            this.groupBox2.Controls.Add(this.GButton);
            this.groupBox2.Controls.Add(this.BButton);
            this.groupBox2.Controls.Add(this.eButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 118);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // eButton
            // 
            this.eButton.Location = new System.Drawing.Point(24, 19);
            this.eButton.Name = "eButton";
            this.eButton.Size = new System.Drawing.Size(39, 23);
            this.eButton.TabIndex = 0;
            this.eButton.Text = "e";
            this.eButton.UseVisualStyleBackColor = true;
            this.eButton.Click += new System.EventHandler(this.eButton_Click);
            // 
            // BButton
            // 
            this.BButton.Location = new System.Drawing.Point(24, 48);
            this.BButton.Name = "BButton";
            this.BButton.Size = new System.Drawing.Size(39, 23);
            this.BButton.TabIndex = 1;
            this.BButton.Text = "B";
            this.BButton.UseVisualStyleBackColor = true;
            this.BButton.Click += new System.EventHandler(this.BButton_Click);
            // 
            // GButton
            // 
            this.GButton.Location = new System.Drawing.Point(24, 77);
            this.GButton.Name = "GButton";
            this.GButton.Size = new System.Drawing.Size(39, 23);
            this.GButton.TabIndex = 2;
            this.GButton.Text = "G";
            this.GButton.UseVisualStyleBackColor = true;
            this.GButton.Click += new System.EventHandler(this.GButton_Click);
            // 
            // DButton
            // 
            this.DButton.Location = new System.Drawing.Point(69, 19);
            this.DButton.Name = "DButton";
            this.DButton.Size = new System.Drawing.Size(39, 23);
            this.DButton.TabIndex = 3;
            this.DButton.Text = "D";
            this.DButton.UseVisualStyleBackColor = true;
            this.DButton.Click += new System.EventHandler(this.DButton_Click);
            // 
            // AButton
            // 
            this.AButton.Location = new System.Drawing.Point(69, 48);
            this.AButton.Name = "AButton";
            this.AButton.Size = new System.Drawing.Size(39, 23);
            this.AButton.TabIndex = 4;
            this.AButton.Text = "A";
            this.AButton.UseVisualStyleBackColor = true;
            this.AButton.Click += new System.EventHandler(this.AButton_Click);
            // 
            // bigEButton
            // 
            this.bigEButton.Location = new System.Drawing.Point(69, 77);
            this.bigEButton.Name = "bigEButton";
            this.bigEButton.Size = new System.Drawing.Size(39, 23);
            this.bigEButton.TabIndex = 5;
            this.bigEButton.Text = "E";
            this.bigEButton.UseVisualStyleBackColor = true;
            this.bigEButton.Click += new System.EventHandler(this.bigEButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Currently Tuning:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tune By Ear:";
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyLabel.Location = new System.Drawing.Point(29, 36);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(0, 69);
            this.keyLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(158, 262);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Guitar Tuner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button eButton;
        private System.Windows.Forms.Button bigEButton;
        private System.Windows.Forms.Button AButton;
        private System.Windows.Forms.Button DButton;
        private System.Windows.Forms.Button GButton;
        private System.Windows.Forms.Button BButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label keyLabel;
    }
}

