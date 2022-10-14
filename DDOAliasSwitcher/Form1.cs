using static DDOAliasSwitcher.Aliases;

namespace DDOAliasSwitcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // C:\Users\r_sod\Documents\Dungeons and Dragons Online\ui\layouts\test.Layout

        private void locButton_Click(object sender, EventArgs e)
        {
            // How to allow the user to search for their file(s) automatically?


        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (raidDayComboBox.Text != "")
            {
                string raidDay = raidDayComboBox.Text;

                ProvideFileInfo(raidDay, locTextBox.Text);
            }
            else
            {
                // Do nothing!
            }
        }

        private void ProvideFileInfo(string raidDay, string fileLoc)
        {
            Aliases alias = new Aliases();
            Dictionary<string, string> aliases = alias.CompileForRaidDay(raidDay);

            Layout layout = new Layout();
            layout.EditXMLForRaidDay(aliases, fileLoc);
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }
    }
}