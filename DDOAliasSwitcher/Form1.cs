using System.Collections.Specialized;
using System.Configuration;
using AutoHotkey.Interop;

namespace DDOAliasSwitcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            NameValueCollection UserSettings = (NameValueCollection)ConfigurationManager.GetSection("UserSettings");
            // Normally this isn't a best practice, but in this case we're going to assume
            // the user will just edit the app.config settings and hopefully not delete them
            try
            {
                string layoutFileLoc = UserSettings[0];
                string defaultFileLoc = UserSettings[1];
                string defaultRaidDay = UserSettings[2];

                if (!string.IsNullOrEmpty(layoutFileLoc))
                {
                    locTextBox.Enabled = false;
                    locTextBox.Text = layoutFileLoc;
                }
                if (!string.IsNullOrEmpty(defaultFileLoc))
                {
                    defaultLocTextBox.Enabled = false;
                    defaultLocTextBox.Text = defaultFileLoc;
                }
                if (!string.IsNullOrEmpty(defaultRaidDay))
                {
                    raidDayComboBox.Text = defaultRaidDay;
                    raidDayComboBox.SelectedValue = defaultRaidDay;
                }
            }
            catch (Exception ex)
            {
                // Do nothing. This is simply to handle the user doing things they shouldn't have,
                // and allow the application to gracefully move on to processing as expected.
            }
        }

        // C:\Users\r_sod\Documents\Dungeons and Dragons Online\ui\layouts

        //https://stackoverflow.com/questions/12769373/how-to-read-values-from-multiple-configuration-file-in-c-sharp-within-a-single-p

        // Longer-term scope
        // TODO: Copy user's layout file, rename LayoutSwitcher.layout to use for this program & AHK script

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (ahkCheckbox.Checked)
            {
                AHK ahk = new AHK();
                ahk.ReloadLayoutInDDO();
            }

            if (raidDayComboBox.SelectedIndex >= 0 && raidDayComboBox.Text != "-----")
            {
                string raidDay = raidDayComboBox.Text;

                ProvideFileInfo(raidDay, locTextBox.Text);

                // TODO: Move AHK script here
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