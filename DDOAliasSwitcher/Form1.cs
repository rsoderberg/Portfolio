namespace DDOAliasSwitcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // C:\Users\r_sod\Documents\Dungeons and Dragons Online\ui\layouts

        //https://stackoverflow.com/questions/12769373/how-to-read-values-from-multiple-configuration-file-in-c-sharp-within-a-single-p

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (raidDayComboBox.SelectedIndex >= 0 && raidDayComboBox.Text != "-----")
            {
                string raidDay = raidDayComboBox.Text;

                ProvideFileInfo(raidDay, locTextBox.Text);
            }
            else
            {
                // Do nothing!
            }
        }

        private void locButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files (*.*)|*.*";
            dlg.FilterIndex = 1;
            dlg.InitialDirectory = "C:\\";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                locTextBox.Text = dlg.FileName;
            }
        }

        private void defaultFileLocButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files (*.*)|*.*";
            dlg.FilterIndex = 1;
            dlg.InitialDirectory = "C:\\";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                defaultLocTextBox.Text = dlg.FileName;
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

        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }
    }
}