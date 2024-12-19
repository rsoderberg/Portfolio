namespace ForestGlenAvailabilityChecker
{
    partial class CheckForm
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
            components = new System.ComponentModel.Container();
            resultsTextbox = new TextBox();
            startButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timerLabel = new Label();
            SuspendLayout();
            // 
            // resultsTextbox
            // 
            resultsTextbox.Location = new Point(12, 12);
            resultsTextbox.Multiline = true;
            resultsTextbox.Name = "resultsTextbox";
            resultsTextbox.Size = new Size(462, 629);
            resultsTextbox.TabIndex = 0;
            // 
            // startButton
            // 
            startButton.Location = new Point(198, 647);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 1;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Location = new Point(459, 651);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(0, 15);
            timerLabel.TabIndex = 2;
            // 
            // CheckForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 680);
            Controls.Add(timerLabel);
            Controls.Add(startButton);
            Controls.Add(resultsTextbox);
            Name = "CheckForm";
            Text = "CheckForm";
            Shown += CheckForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox resultsTextbox;
        private Button startButton;
        private System.Windows.Forms.Timer timer1;
        private Label timerLabel;
    }
}
