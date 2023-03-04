namespace DDOAliasSwitcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
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
            }
            catch (Exception ex)
            {
                // Do nothing!
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (raidDayComboBox.SelectedIndex >= 0 && raidDayComboBox.Text != "-----")
            {
                string raidDay = raidDayComboBox.Text;

                // TODO: Figure out which layout fields we no longer need, with the DASLayout file

                try
                {
                    // Save user's most recent layout file locations
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
                    UserSettings.Default.Save();

                    // Generate/copy the DASLayout.layout file for use by script
                    var dir = Path.GetDirectoryName(locTextBox.Text);

                    string DASLayoutLoc = $"{dir}\\DASLayout.layout";
                    File.Copy(locTextBox.Text, DASLayoutLoc, true);

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
                // Do nothing!
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
            // https://stackoverflow.com/questions/11624298/how-do-i-use-openfiledialog-to-select-a-folder

            // FolderBrowserDialog
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Layout Files (*.layout)|*.layout";
            dlg.FilterIndex = 1;
            dlg.InitialDirectory = "C:\\..\\Dungeons and Dragons Online\\ui\\layouts";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                locTextBox.Text = dlg.FileName;
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