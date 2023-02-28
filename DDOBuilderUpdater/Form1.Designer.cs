namespace DDOBuilderUpdater
{
    partial class UpdaterForm
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
            this.mainTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // mainTextBox
            // 
            this.mainTextBox.Location = new System.Drawing.Point(12, 12);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(330, 465);
            this.mainTextBox.TabIndex = 0;
            this.mainTextBox.Text = "";
            // 
            // UpdaterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 489);
            this.Controls.Add(this.mainTextBox);
            this.Name = "UpdaterForm";
            this.Text = "Update Maetrim DDO Builder";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox mainTextBox;
    }
}