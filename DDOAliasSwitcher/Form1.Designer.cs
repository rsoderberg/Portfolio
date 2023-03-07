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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ahkCheckbox = new System.Windows.Forms.CheckBox();
            this.raidsGroupBox = new System.Windows.Forms.GroupBox();
            this.babaCheckBox = new System.Windows.Forms.CheckBox();
            this.defaultCheckBox = new System.Windows.Forms.CheckBox();
            this.stubCheckBox5 = new System.Windows.Forms.CheckBox();
            this.stubCheckBox4 = new System.Windows.Forms.CheckBox();
            this.stubCheckBox3 = new System.Windows.Forms.CheckBox();
            this.stubCheckBox2 = new System.Windows.Forms.CheckBox();
            this.stubCheckBox1 = new System.Windows.Forms.CheckBox();
            this.zrCheckBox = new System.Windows.Forms.CheckBox();
            this.vonCheckBox = new System.Windows.Forms.CheckBox();
            this.vodCheckBox = new System.Windows.Forms.CheckBox();
            this.ththCheckBox = new System.Windows.Forms.CheckBox();
            this.deathwyrmCheckBox = new System.Windows.Forms.CheckBox();
            this.skelesTalkCheckBox = new System.Windows.Forms.CheckBox();
            this.skelesCheckBox = new System.Windows.Forms.CheckBox();
            this.rtsoCheckBox = new System.Windows.Forms.CheckBox();
            this.pnCheckBox = new System.Windows.Forms.CheckBox();
            this.ponCheckBox = new System.Windows.Forms.CheckBox();
            this.maCheckBox = new System.Windows.Forms.CheckBox();
            this.modCheckBox = new System.Windows.Forms.CheckBox();
            this.lobCheckBox = new System.Windows.Forms.CheckBox();
            this.ktCheckBox = new System.Windows.Forms.CheckBox();
            this.huntCheckBox = new System.Windows.Forms.CheckBox();
            this.hoxCheckBox = new System.Windows.Forms.CheckBox();
            this.fotpCheckBox = new System.Windows.Forms.CheckBox();
            this.fotCheckBox = new System.Windows.Forms.CheckBox();
            this.dryadCheckBox = new System.Windows.Forms.CheckBox();
            this.dojCheckBox = new System.Windows.Forms.CheckBox();
            this.strahdCheckBox = new System.Windows.Forms.CheckBox();
            this.shroudCheckBox = new System.Windows.Forms.CheckBox();
            this.chronoCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.counterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.raidsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // locTextBox
            // 
            this.locTextBox.Location = new System.Drawing.Point(96, 96);
            this.locTextBox.Name = "locTextBox";
            this.locTextBox.Size = new System.Drawing.Size(236, 23);
            this.locTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Where is your\r\nLayout file?";
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
            this.ahkCheckbox.Location = new System.Drawing.Point(264, 199);
            this.ahkCheckbox.Name = "ahkCheckbox";
            this.ahkCheckbox.Size = new System.Drawing.Size(107, 19);
            this.ahkCheckbox.TabIndex = 23;
            this.ahkCheckbox.Text = "Run AHK Script";
            this.ahkCheckbox.UseVisualStyleBackColor = true;
            // 
            // raidsGroupBox
            // 
            this.raidsGroupBox.Controls.Add(this.babaCheckBox);
            this.raidsGroupBox.Controls.Add(this.defaultCheckBox);
            this.raidsGroupBox.Controls.Add(this.stubCheckBox5);
            this.raidsGroupBox.Controls.Add(this.stubCheckBox4);
            this.raidsGroupBox.Controls.Add(this.stubCheckBox3);
            this.raidsGroupBox.Controls.Add(this.stubCheckBox2);
            this.raidsGroupBox.Controls.Add(this.stubCheckBox1);
            this.raidsGroupBox.Controls.Add(this.zrCheckBox);
            this.raidsGroupBox.Controls.Add(this.vonCheckBox);
            this.raidsGroupBox.Controls.Add(this.vodCheckBox);
            this.raidsGroupBox.Controls.Add(this.ththCheckBox);
            this.raidsGroupBox.Controls.Add(this.deathwyrmCheckBox);
            this.raidsGroupBox.Controls.Add(this.skelesTalkCheckBox);
            this.raidsGroupBox.Controls.Add(this.skelesCheckBox);
            this.raidsGroupBox.Controls.Add(this.rtsoCheckBox);
            this.raidsGroupBox.Controls.Add(this.pnCheckBox);
            this.raidsGroupBox.Controls.Add(this.ponCheckBox);
            this.raidsGroupBox.Controls.Add(this.maCheckBox);
            this.raidsGroupBox.Controls.Add(this.modCheckBox);
            this.raidsGroupBox.Controls.Add(this.lobCheckBox);
            this.raidsGroupBox.Controls.Add(this.ktCheckBox);
            this.raidsGroupBox.Controls.Add(this.huntCheckBox);
            this.raidsGroupBox.Controls.Add(this.hoxCheckBox);
            this.raidsGroupBox.Controls.Add(this.fotpCheckBox);
            this.raidsGroupBox.Controls.Add(this.fotCheckBox);
            this.raidsGroupBox.Controls.Add(this.dryadCheckBox);
            this.raidsGroupBox.Controls.Add(this.dojCheckBox);
            this.raidsGroupBox.Controls.Add(this.strahdCheckBox);
            this.raidsGroupBox.Controls.Add(this.shroudCheckBox);
            this.raidsGroupBox.Controls.Add(this.chronoCheckBox);
            this.raidsGroupBox.Location = new System.Drawing.Point(12, 246);
            this.raidsGroupBox.Name = "raidsGroupBox";
            this.raidsGroupBox.Size = new System.Drawing.Size(515, 282);
            this.raidsGroupBox.TabIndex = 24;
            this.raidsGroupBox.TabStop = false;
            this.raidsGroupBox.Text = "Raids";
            // 
            // babaCheckBox
            // 
            this.babaCheckBox.AutoSize = true;
            this.babaCheckBox.Location = new System.Drawing.Point(178, 97);
            this.babaCheckBox.Name = "babaCheckBox";
            this.babaCheckBox.Size = new System.Drawing.Size(105, 19);
            this.babaCheckBox.TabIndex = 29;
            this.babaCheckBox.Text = "Old Baba\'s Hut";
            this.babaCheckBox.UseVisualStyleBackColor = true;
            this.babaCheckBox.CheckedChanged += new System.EventHandler(this.babaCheckBox_CheckedChanged);
            // 
            // defaultCheckBox
            // 
            this.defaultCheckBox.AutoSize = true;
            this.defaultCheckBox.Location = new System.Drawing.Point(357, 247);
            this.defaultCheckBox.Name = "defaultCheckBox";
            this.defaultCheckBox.Size = new System.Drawing.Size(103, 19);
            this.defaultCheckBox.TabIndex = 28;
            this.defaultCheckBox.Text = "Default Layout";
            this.defaultCheckBox.UseVisualStyleBackColor = true;
            this.defaultCheckBox.CheckedChanged += new System.EventHandler(this.defaultCheckBox_CheckedChanged);
            // 
            // stubCheckBox5
            // 
            this.stubCheckBox5.AutoSize = true;
            this.stubCheckBox5.Enabled = false;
            this.stubCheckBox5.Location = new System.Drawing.Point(357, 222);
            this.stubCheckBox5.Name = "stubCheckBox5";
            this.stubCheckBox5.Size = new System.Drawing.Size(59, 19);
            this.stubCheckBox5.TabIndex = 27;
            this.stubCheckBox5.Text = "Stub 5";
            this.stubCheckBox5.UseVisualStyleBackColor = true;
            this.stubCheckBox5.Visible = false;
            // 
            // stubCheckBox4
            // 
            this.stubCheckBox4.AutoSize = true;
            this.stubCheckBox4.Enabled = false;
            this.stubCheckBox4.Location = new System.Drawing.Point(357, 197);
            this.stubCheckBox4.Name = "stubCheckBox4";
            this.stubCheckBox4.Size = new System.Drawing.Size(59, 19);
            this.stubCheckBox4.TabIndex = 26;
            this.stubCheckBox4.Text = "Stub 4";
            this.stubCheckBox4.UseVisualStyleBackColor = true;
            this.stubCheckBox4.Visible = false;
            // 
            // stubCheckBox3
            // 
            this.stubCheckBox3.AutoSize = true;
            this.stubCheckBox3.Enabled = false;
            this.stubCheckBox3.Location = new System.Drawing.Point(357, 172);
            this.stubCheckBox3.Name = "stubCheckBox3";
            this.stubCheckBox3.Size = new System.Drawing.Size(59, 19);
            this.stubCheckBox3.TabIndex = 25;
            this.stubCheckBox3.Text = "Stub 3";
            this.stubCheckBox3.UseVisualStyleBackColor = true;
            this.stubCheckBox3.Visible = false;
            // 
            // stubCheckBox2
            // 
            this.stubCheckBox2.AutoSize = true;
            this.stubCheckBox2.Enabled = false;
            this.stubCheckBox2.Location = new System.Drawing.Point(357, 147);
            this.stubCheckBox2.Name = "stubCheckBox2";
            this.stubCheckBox2.Size = new System.Drawing.Size(59, 19);
            this.stubCheckBox2.TabIndex = 24;
            this.stubCheckBox2.Text = "Stub 2";
            this.stubCheckBox2.UseVisualStyleBackColor = true;
            this.stubCheckBox2.Visible = false;
            // 
            // stubCheckBox1
            // 
            this.stubCheckBox1.AutoSize = true;
            this.stubCheckBox1.Enabled = false;
            this.stubCheckBox1.Location = new System.Drawing.Point(357, 122);
            this.stubCheckBox1.Name = "stubCheckBox1";
            this.stubCheckBox1.Size = new System.Drawing.Size(59, 19);
            this.stubCheckBox1.TabIndex = 23;
            this.stubCheckBox1.Text = "Stub 1";
            this.stubCheckBox1.UseVisualStyleBackColor = true;
            this.stubCheckBox1.Visible = false;
            // 
            // zrCheckBox
            // 
            this.zrCheckBox.AutoSize = true;
            this.zrCheckBox.Location = new System.Drawing.Point(357, 97);
            this.zrCheckBox.Name = "zrCheckBox";
            this.zrCheckBox.Size = new System.Drawing.Size(120, 19);
            this.zrCheckBox.TabIndex = 22;
            this.zrCheckBox.Text = "Zawabi\'s Revenge";
            this.zrCheckBox.UseVisualStyleBackColor = true;
            this.zrCheckBox.CheckedChanged += new System.EventHandler(this.zrCheckBox_CheckedChanged);
            // 
            // vonCheckBox
            // 
            this.vonCheckBox.AutoSize = true;
            this.vonCheckBox.Location = new System.Drawing.Point(357, 72);
            this.vonCheckBox.Name = "vonCheckBox";
            this.vonCheckBox.Size = new System.Drawing.Size(99, 19);
            this.vonCheckBox.TabIndex = 21;
            this.vonCheckBox.Text = "Vault of Night";
            this.vonCheckBox.UseVisualStyleBackColor = true;
            this.vonCheckBox.CheckedChanged += new System.EventHandler(this.vonCheckBox_CheckedChanged);
            // 
            // vodCheckBox
            // 
            this.vodCheckBox.AutoSize = true;
            this.vodCheckBox.Location = new System.Drawing.Point(357, 47);
            this.vodCheckBox.Name = "vodCheckBox";
            this.vodCheckBox.Size = new System.Drawing.Size(136, 19);
            this.vodCheckBox.TabIndex = 20;
            this.vodCheckBox.Text = "Vision of Destruction";
            this.vodCheckBox.UseVisualStyleBackColor = true;
            this.vodCheckBox.CheckedChanged += new System.EventHandler(this.vodCheckBox_CheckedChanged);
            // 
            // ththCheckBox
            // 
            this.ththCheckBox.AutoSize = true;
            this.ththCheckBox.Location = new System.Drawing.Point(357, 22);
            this.ththCheckBox.Name = "ththCheckBox";
            this.ththCheckBox.Size = new System.Drawing.Size(123, 19);
            this.ththCheckBox.TabIndex = 19;
            this.ththCheckBox.Text = "Too Hot to Handle";
            this.ththCheckBox.UseVisualStyleBackColor = true;
            this.ththCheckBox.CheckedChanged += new System.EventHandler(this.ththCheckBox_CheckedChanged);
            // 
            // deathwyrmCheckBox
            // 
            this.deathwyrmCheckBox.AutoSize = true;
            this.deathwyrmCheckBox.Location = new System.Drawing.Point(178, 247);
            this.deathwyrmCheckBox.Name = "deathwyrmCheckBox";
            this.deathwyrmCheckBox.Size = new System.Drawing.Size(142, 19);
            this.deathwyrmCheckBox.TabIndex = 18;
            this.deathwyrmCheckBox.Text = "Temple of Deathwyrm";
            this.deathwyrmCheckBox.UseVisualStyleBackColor = true;
            this.deathwyrmCheckBox.CheckedChanged += new System.EventHandler(this.deathwyrmCheckBox_CheckedChanged);
            // 
            // skelesTalkCheckBox
            // 
            this.skelesTalkCheckBox.AutoSize = true;
            this.skelesTalkCheckBox.Location = new System.Drawing.Point(178, 222);
            this.skelesTalkCheckBox.Name = "skelesTalkCheckBox";
            this.skelesTalkCheckBox.Size = new System.Drawing.Size(139, 19);
            this.skelesTalkCheckBox.TabIndex = 17;
            this.skelesTalkCheckBox.Text = "Skeletons Talking Opt";
            this.skelesTalkCheckBox.UseVisualStyleBackColor = true;
            this.skelesTalkCheckBox.CheckedChanged += new System.EventHandler(this.skelesTalkCheckBox_CheckedChanged);
            // 
            // skelesCheckBox
            // 
            this.skelesCheckBox.AutoSize = true;
            this.skelesCheckBox.Location = new System.Drawing.Point(178, 197);
            this.skelesCheckBox.Name = "skelesCheckBox";
            this.skelesCheckBox.Size = new System.Drawing.Size(145, 19);
            this.skelesCheckBox.TabIndex = 16;
            this.skelesCheckBox.Text = "Skeletons in the Closet";
            this.skelesCheckBox.UseVisualStyleBackColor = true;
            this.skelesCheckBox.CheckedChanged += new System.EventHandler(this.skelesCheckBox_CheckedChanged);
            // 
            // rtsoCheckBox
            // 
            this.rtsoCheckBox.AutoSize = true;
            this.rtsoCheckBox.Location = new System.Drawing.Point(178, 172);
            this.rtsoCheckBox.Name = "rtsoCheckBox";
            this.rtsoCheckBox.Size = new System.Drawing.Size(138, 19);
            this.rtsoCheckBox.TabIndex = 15;
            this.rtsoCheckBox.Text = "Riding the Storm Out";
            this.rtsoCheckBox.UseVisualStyleBackColor = true;
            this.rtsoCheckBox.CheckedChanged += new System.EventHandler(this.rtsoCheckBox_CheckedChanged);
            // 
            // pnCheckBox
            // 
            this.pnCheckBox.AutoSize = true;
            this.pnCheckBox.Location = new System.Drawing.Point(178, 147);
            this.pnCheckBox.Name = "pnCheckBox";
            this.pnCheckBox.Size = new System.Drawing.Size(111, 19);
            this.pnCheckBox.TabIndex = 14;
            this.pnCheckBox.Text = "Project Nemesis";
            this.pnCheckBox.UseVisualStyleBackColor = true;
            this.pnCheckBox.CheckedChanged += new System.EventHandler(this.pnCheckBox_CheckedChanged);
            // 
            // ponCheckBox
            // 
            this.ponCheckBox.AutoSize = true;
            this.ponCheckBox.Location = new System.Drawing.Point(178, 122);
            this.ponCheckBox.Name = "ponCheckBox";
            this.ponCheckBox.Size = new System.Drawing.Size(102, 19);
            this.ponCheckBox.TabIndex = 13;
            this.ponCheckBox.Text = "Plane of Night";
            this.ponCheckBox.UseVisualStyleBackColor = true;
            this.ponCheckBox.CheckedChanged += new System.EventHandler(this.ponCheckBox_CheckedChanged);
            // 
            // maCheckBox
            // 
            this.maCheckBox.AutoSize = true;
            this.maCheckBox.Location = new System.Drawing.Point(178, 72);
            this.maCheckBox.Name = "maCheckBox";
            this.maCheckBox.Size = new System.Drawing.Size(107, 19);
            this.maCheckBox.TabIndex = 12;
            this.maCheckBox.Text = "Master Artificer";
            this.maCheckBox.UseVisualStyleBackColor = true;
            this.maCheckBox.CheckedChanged += new System.EventHandler(this.maCheckBox_CheckedChanged);
            // 
            // modCheckBox
            // 
            this.modCheckBox.AutoSize = true;
            this.modCheckBox.Location = new System.Drawing.Point(178, 47);
            this.modCheckBox.Name = "modCheckBox";
            this.modCheckBox.Size = new System.Drawing.Size(101, 19);
            this.modCheckBox.TabIndex = 11;
            this.modCheckBox.Text = "Mark of Death";
            this.modCheckBox.UseVisualStyleBackColor = true;
            this.modCheckBox.CheckedChanged += new System.EventHandler(this.modCheckBox_CheckedChanged);
            // 
            // lobCheckBox
            // 
            this.lobCheckBox.AutoSize = true;
            this.lobCheckBox.Location = new System.Drawing.Point(178, 22);
            this.lobCheckBox.Name = "lobCheckBox";
            this.lobCheckBox.Size = new System.Drawing.Size(101, 19);
            this.lobCheckBox.TabIndex = 10;
            this.lobCheckBox.Text = "Lord of Blades";
            this.lobCheckBox.UseVisualStyleBackColor = true;
            this.lobCheckBox.CheckedChanged += new System.EventHandler(this.lobCheckBox_CheckedChanged);
            // 
            // ktCheckBox
            // 
            this.ktCheckBox.AutoSize = true;
            this.ktCheckBox.Location = new System.Drawing.Point(6, 247);
            this.ktCheckBox.Name = "ktCheckBox";
            this.ktCheckBox.Size = new System.Drawing.Size(88, 19);
            this.ktCheckBox.TabIndex = 9;
            this.ktCheckBox.Text = "Killing Time";
            this.ktCheckBox.UseVisualStyleBackColor = true;
            this.ktCheckBox.CheckedChanged += new System.EventHandler(this.ktCheckBox_CheckedChanged);
            // 
            // huntCheckBox
            // 
            this.huntCheckBox.AutoSize = true;
            this.huntCheckBox.Location = new System.Drawing.Point(6, 222);
            this.huntCheckBox.Name = "huntCheckBox";
            this.huntCheckBox.Size = new System.Drawing.Size(126, 19);
            this.huntCheckBox.TabIndex = 8;
            this.huntCheckBox.Text = "Hunt or be Hunted";
            this.huntCheckBox.UseVisualStyleBackColor = true;
            this.huntCheckBox.CheckedChanged += new System.EventHandler(this.huntCheckBox_CheckedChanged);
            // 
            // hoxCheckBox
            // 
            this.hoxCheckBox.AutoSize = true;
            this.hoxCheckBox.Location = new System.Drawing.Point(6, 197);
            this.hoxCheckBox.Name = "hoxCheckBox";
            this.hoxCheckBox.Size = new System.Drawing.Size(111, 19);
            this.hoxCheckBox.TabIndex = 7;
            this.hoxCheckBox.Text = "Hound of Xoriat";
            this.hoxCheckBox.UseVisualStyleBackColor = true;
            this.hoxCheckBox.CheckedChanged += new System.EventHandler(this.hoxCheckBox_CheckedChanged);
            // 
            // fotpCheckBox
            // 
            this.fotpCheckBox.AutoSize = true;
            this.fotpCheckBox.Location = new System.Drawing.Point(6, 172);
            this.fotpCheckBox.Name = "fotpCheckBox";
            this.fotpCheckBox.Size = new System.Drawing.Size(137, 19);
            this.fotpCheckBox.TabIndex = 6;
            this.fotpCheckBox.Text = "Fire on Thunder Peak";
            this.fotpCheckBox.UseVisualStyleBackColor = true;
            this.fotpCheckBox.CheckedChanged += new System.EventHandler(this.fotpCheckBox_CheckedChanged);
            // 
            // fotCheckBox
            // 
            this.fotCheckBox.AutoSize = true;
            this.fotCheckBox.Location = new System.Drawing.Point(6, 147);
            this.fotCheckBox.Name = "fotCheckBox";
            this.fotCheckBox.Size = new System.Drawing.Size(88, 19);
            this.fotCheckBox.TabIndex = 5;
            this.fotCheckBox.Text = "Fall of Truth";
            this.fotCheckBox.UseVisualStyleBackColor = true;
            this.fotCheckBox.CheckedChanged += new System.EventHandler(this.fotCheckBox_CheckedChanged);
            // 
            // dryadCheckBox
            // 
            this.dryadCheckBox.AutoSize = true;
            this.dryadCheckBox.Location = new System.Drawing.Point(6, 122);
            this.dryadCheckBox.Name = "dryadCheckBox";
            this.dryadCheckBox.Size = new System.Drawing.Size(152, 19);
            this.dryadCheckBox.TabIndex = 4;
            this.dryadCheckBox.Text = "Dryad and the Demigod";
            this.dryadCheckBox.UseVisualStyleBackColor = true;
            this.dryadCheckBox.CheckedChanged += new System.EventHandler(this.dryadCheckBox_CheckedChanged);
            // 
            // dojCheckBox
            // 
            this.dojCheckBox.AutoSize = true;
            this.dojCheckBox.Location = new System.Drawing.Point(6, 97);
            this.dojCheckBox.Name = "dojCheckBox";
            this.dojCheckBox.Size = new System.Drawing.Size(117, 19);
            this.dojCheckBox.TabIndex = 3;
            this.dojCheckBox.Text = "Defiler of the Just";
            this.dojCheckBox.UseVisualStyleBackColor = true;
            this.dojCheckBox.CheckedChanged += new System.EventHandler(this.dojCheckBox_CheckedChanged);
            // 
            // strahdCheckBox
            // 
            this.strahdCheckBox.AutoSize = true;
            this.strahdCheckBox.Location = new System.Drawing.Point(6, 72);
            this.strahdCheckBox.Name = "strahdCheckBox";
            this.strahdCheckBox.Size = new System.Drawing.Size(107, 19);
            this.strahdCheckBox.TabIndex = 2;
            this.strahdCheckBox.Text = "Curse of Strahd";
            this.strahdCheckBox.UseVisualStyleBackColor = true;
            this.strahdCheckBox.CheckedChanged += new System.EventHandler(this.strahdCheckBox_CheckedChanged);
            // 
            // shroudCheckBox
            // 
            this.shroudCheckBox.AutoSize = true;
            this.shroudCheckBox.Location = new System.Drawing.Point(6, 47);
            this.shroudCheckBox.Name = "shroudCheckBox";
            this.shroudCheckBox.Size = new System.Drawing.Size(144, 19);
            this.shroudCheckBox.TabIndex = 1;
            this.shroudCheckBox.Text = "Codex and the Shroud";
            this.shroudCheckBox.UseVisualStyleBackColor = true;
            this.shroudCheckBox.CheckedChanged += new System.EventHandler(this.shroudCheckBox_CheckedChanged);
            // 
            // chronoCheckBox
            // 
            this.chronoCheckBox.AutoSize = true;
            this.chronoCheckBox.Location = new System.Drawing.Point(6, 22);
            this.chronoCheckBox.Name = "chronoCheckBox";
            this.chronoCheckBox.Size = new System.Drawing.Size(97, 19);
            this.chronoCheckBox.TabIndex = 0;
            this.chronoCheckBox.Text = "Chronoscope";
            this.chronoCheckBox.UseVisualStyleBackColor = true;
            this.chronoCheckBox.CheckedChanged += new System.EventHandler(this.chronoCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "# of aliases:";
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.Location = new System.Drawing.Point(474, 234);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(0, 15);
            this.counterLabel.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 540);
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.raidsGroupBox);
            this.Controls.Add(this.ahkCheckbox);
            this.Controls.Add(this.pictureBox1);
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
            this.raidsGroupBox.ResumeLayout(false);
            this.raidsGroupBox.PerformLayout();
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
        private PictureBox pictureBox1;
        private CheckBox ahkCheckbox;
        private GroupBox raidsGroupBox;
        private CheckBox defaultCheckBox;
        private CheckBox stubCheckBox5;
        private CheckBox stubCheckBox4;
        private CheckBox stubCheckBox3;
        private CheckBox stubCheckBox2;
        private CheckBox stubCheckBox1;
        private CheckBox zrCheckBox;
        private CheckBox vonCheckBox;
        private CheckBox vodCheckBox;
        private CheckBox ththCheckBox;
        private CheckBox deathwyrmCheckBox;
        private CheckBox skelesTalkCheckBox;
        private CheckBox skelesCheckBox;
        private CheckBox rtsoCheckBox;
        private CheckBox pnCheckBox;
        private CheckBox ponCheckBox;
        private CheckBox maCheckBox;
        private CheckBox modCheckBox;
        private CheckBox lobCheckBox;
        private CheckBox ktCheckBox;
        private CheckBox huntCheckBox;
        private CheckBox hoxCheckBox;
        private CheckBox fotpCheckBox;
        private CheckBox fotCheckBox;
        private CheckBox dryadCheckBox;
        private CheckBox dojCheckBox;
        private CheckBox strahdCheckBox;
        private CheckBox shroudCheckBox;
        private CheckBox chronoCheckBox;
        private CheckBox babaCheckBox;
        private Label label2;
        private Label counterLabel;
    }
}