namespace ShapeTool
{
    partial class shapeForm
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
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.circLabel = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.squareRadioButton = new System.Windows.Forms.RadioButton();
            this.circleRadioButton = new System.Windows.Forms.RadioButton();
            this.shapeGroupBox = new System.Windows.Forms.GroupBox();
            this.rectangleRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.shapeGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(18, 53);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(52, 17);
            this.lengthLabel.TabIndex = 2;
            this.lengthLabel.Text = "Length";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(18, 84);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(44, 17);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "Width";
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(18, 84);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(52, 17);
            this.radiusLabel.TabIndex = 5;
            this.radiusLabel.Text = "Radius";
            // 
            // circLabel
            // 
            this.circLabel.AutoSize = true;
            this.circLabel.Location = new System.Drawing.Point(18, 53);
            this.circLabel.Name = "circLabel";
            this.circLabel.Size = new System.Drawing.Size(59, 17);
            this.circLabel.TabIndex = 6;
            this.circLabel.Text = "Circumf.";
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(18, 23);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(38, 17);
            this.areaLabel.TabIndex = 7;
            this.areaLabel.Text = "Area";
            // 
            // areaTextBox
            // 
            this.areaTextBox.Location = new System.Drawing.Point(81, 20);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(82, 22);
            this.areaTextBox.TabIndex = 8;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(81, 81);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(82, 22);
            this.widthTextBox.TabIndex = 10;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(81, 50);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(82, 22);
            this.lengthTextBox.TabIndex = 11;
            // 
            // squareRadioButton
            // 
            this.squareRadioButton.AutoSize = true;
            this.squareRadioButton.Location = new System.Drawing.Point(6, 26);
            this.squareRadioButton.Name = "squareRadioButton";
            this.squareRadioButton.Size = new System.Drawing.Size(75, 21);
            this.squareRadioButton.TabIndex = 12;
            this.squareRadioButton.TabStop = true;
            this.squareRadioButton.Text = "Square";
            this.squareRadioButton.UseVisualStyleBackColor = true;
            this.squareRadioButton.CheckedChanged += new System.EventHandler(this.squareRadioButton_CheckedChanged);
            // 
            // circleRadioButton
            // 
            this.circleRadioButton.AutoSize = true;
            this.circleRadioButton.Location = new System.Drawing.Point(6, 80);
            this.circleRadioButton.Name = "circleRadioButton";
            this.circleRadioButton.Size = new System.Drawing.Size(64, 21);
            this.circleRadioButton.TabIndex = 14;
            this.circleRadioButton.TabStop = true;
            this.circleRadioButton.Text = "Circle";
            this.circleRadioButton.UseVisualStyleBackColor = true;
            this.circleRadioButton.CheckedChanged += new System.EventHandler(this.circleRadioButton_CheckedChanged);
            // 
            // shapeGroupBox
            // 
            this.shapeGroupBox.Controls.Add(this.rectangleRadioButton);
            this.shapeGroupBox.Controls.Add(this.circleRadioButton);
            this.shapeGroupBox.Controls.Add(this.squareRadioButton);
            this.shapeGroupBox.Location = new System.Drawing.Point(8, 8);
            this.shapeGroupBox.Name = "shapeGroupBox";
            this.shapeGroupBox.Size = new System.Drawing.Size(118, 112);
            this.shapeGroupBox.TabIndex = 15;
            this.shapeGroupBox.TabStop = false;
            this.shapeGroupBox.Text = "Select Shape:";
            // 
            // rectangleRadioButton
            // 
            this.rectangleRadioButton.AutoSize = true;
            this.rectangleRadioButton.Location = new System.Drawing.Point(6, 53);
            this.rectangleRadioButton.Name = "rectangleRadioButton";
            this.rectangleRadioButton.Size = new System.Drawing.Size(93, 21);
            this.rectangleRadioButton.TabIndex = 13;
            this.rectangleRadioButton.TabStop = true;
            this.rectangleRadioButton.Text = "Rectangle";
            this.rectangleRadioButton.UseVisualStyleBackColor = true;
            this.rectangleRadioButton.CheckedChanged += new System.EventHandler(this.rectangleRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.areaTextBox);
            this.groupBox1.Controls.Add(this.lengthLabel);
            this.groupBox1.Controls.Add(this.lengthTextBox);
            this.groupBox1.Controls.Add(this.widthLabel);
            this.groupBox1.Controls.Add(this.radiusLabel);
            this.groupBox1.Controls.Add(this.circLabel);
            this.groupBox1.Controls.Add(this.widthTextBox);
            this.groupBox1.Controls.Add(this.areaLabel);
            this.groupBox1.Location = new System.Drawing.Point(133, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 112);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shape Dimensions:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(46, 126);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(119, 38);
            this.calculateButton.TabIndex = 17;
            this.calculateButton.Text = " Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(171, 136);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 28);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // shapeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 171);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.shapeGroupBox);
            this.Name = "shapeForm";
            this.Text = "Shape Tool";
            this.shapeGroupBox.ResumeLayout(false);
            this.shapeGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.Label circLabel;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.RadioButton squareRadioButton;
        private System.Windows.Forms.RadioButton circleRadioButton;
        private System.Windows.Forms.GroupBox shapeGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RadioButton rectangleRadioButton;
    }
}

