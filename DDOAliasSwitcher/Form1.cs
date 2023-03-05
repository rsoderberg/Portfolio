namespace DDOAliasSwitcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                // Update the form with any settings the user previously used
                if (!string.IsNullOrEmpty(UserSettings.Default.LayoutFileLocation))
                {
                    locTextBox.Text = UserSettings.Default.LayoutFileLocation;
                }
                if (!string.IsNullOrEmpty(UserSettings.Default.DefaultFileLocation))
                {
                    defaultLocTextBox.Text = UserSettings.Default.DefaultFileLocation;
                }
                if (!string.IsNullOrEmpty(UserSettings.Default.DefaultRaidDay))
                {
                    raidDayComboBox.Text = UserSettings.Default.DefaultRaidDay;
                    raidDayComboBox.SelectedValue = UserSettings.Default.DefaultRaidDay;
                }
                ahkCheckbox.Checked = UserSettings.Default.RunAHK;
            }
            catch (Exception ex)
            {
                // Do nothing, failure here will simply not save a user's settings
                // for their next session. No biggie, just a little annoying.
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(locTextBox.Text))
            {
                if (raidDayComboBox.SelectedIndex >= 0 && raidDayComboBox.Text != "-----")
                {
                    string raidDay = raidDayComboBox.Text;

                    try
                    {
                        // Save user's most recent layout file settings
                        if (locTextBox.Text != UserSettings.Default.LayoutFileLocation)
                        {
                            UserSettings.Default.LayoutFileLocation = locTextBox.Text;
                        }
                        if (defaultLocTextBox.Text != UserSettings.Default.DefaultFileLocation)
                        {
                            UserSettings.Default.DefaultFileLocation = defaultLocTextBox.Text;
                        }
                        if (raidDayComboBox.Text != UserSettings.Default.DefaultRaidDay)
                        {
                            UserSettings.Default.DefaultRaidDay = raidDayComboBox.Text;
                        }
                        UserSettings.Default.RunAHK = ahkCheckbox.Checked;

                        UserSettings.Default.Save();

                        // Generate/copy the DASLayout.layout file for use by application and script
                        var dir = locTextBox.Text;

                        string DASLayoutLoc = $"{dir}\\DASLayout.layout";
                        var DASFile = File.Create(DASLayoutLoc);
                        DASFile.Close();

                        ProvideFileInfo(raidDay, DASLayoutLoc);

                        if (ahkCheckbox.Checked)
                        {
                            AHK ahk = new AHK();
                            ahk.ReloadLayoutInDDO();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please use the dropdown to choose your alias settings.", 
                        "Missing values", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please select your layout folder location in the \"Layouts Folder\" field.", 
                    "Missing values", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ProvideFileInfo(string raidDay, string fileLoc)
        {
            LayoutBuilder layout = new LayoutBuilder();
            Aliases alias = new Aliases();

            Dictionary<string, string> aliasLines = new Dictionary<string, string>();

            if (raidDay == "MyDefaultFile" && !string.IsNullOrEmpty(defaultLocTextBox.Text))
            {
                aliasLines = alias.CompileFromDefaultFile(defaultLocTextBox.Text);
            }
            else
            {
                aliasLines = alias.CompileForRaidDay(raidDay);
            }

            layout.EditXMLForRaidDay(aliasLines, fileLoc);
        }

        private void locButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.InitialDirectory = "C:\\..\\Dungeons and Dragons Online\\ui\\layouts";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                locTextBox.Text = dlg.SelectedPath;
            }
        }

        private void defaultFileLocButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Layout Files (*.layout)|*.layout";
            dlg.FilterIndex = 1;
            dlg.InitialDirectory = "C:\\..\\Dungeons and Dragons Online\\ui\\layouts";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                defaultLocTextBox.Text = dlg.FileName;
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }
    }
}