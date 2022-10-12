namespace DDOAliasSwitcher
{
    partial class HelpForm
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
            this.helpTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // helpTextBox
            // 
            this.helpTextBox.Location = new System.Drawing.Point(12, 12);
            this.helpTextBox.Multiline = true;
            this.helpTextBox.Name = "helpTextBox";
            this.helpTextBox.ReadOnly = true;
            this.helpTextBox.Size = new System.Drawing.Size(491, 708);
            this.helpTextBox.TabIndex = 0;
            this.helpTextBox.Text = "- This is how you use the application:\r\n- EZPZ Lemon Squeezy\r\n- Don\'t be bad\r\n";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 732);
            this.Controls.Add(this.helpTextBox);
            this.Name = "HelpForm";
            this.Text = "Need Help?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox helpTextBox;
    }
}