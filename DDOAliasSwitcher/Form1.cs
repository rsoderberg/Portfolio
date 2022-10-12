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

        private void monButton_Click(object sender, EventArgs e)
        {
            ProvideFileInfo("Monday", locTextBox.Text);
        }

        private void tuesButton_Click(object sender, EventArgs e)
        {
            ProvideFileInfo("Tuesday", locTextBox.Text);
        }

        private void wedButton_Click(object sender, EventArgs e)
        {
            ProvideFileInfo("Wednesday", locTextBox.Text);
        }

        private void thursButton_Click(object sender, EventArgs e)
        {
            ProvideFileInfo("Thursday", locTextBox.Text);
        }

        private void friButton_Click(object sender, EventArgs e)
        {
            ProvideFileInfo("Friday", locTextBox.Text);
        }

        private void satAM1Button_Click(object sender, EventArgs e)
        {
            ProvideFileInfo("SaturdayAM1", locTextBox.Text);
        }

        private void satAM2Button_Click(object sender, EventArgs e)
        {
            ProvideFileInfo("SaturdayAM2", locTextBox.Text);
        }

        private void satPMButton_Click(object sender, EventArgs e)
        {
            ProvideFileInfo("SaturdayPM", locTextBox.Text);
        }

        private void sunButton_Click(object sender, EventArgs e)
        {
            ProvideFileInfo("Sunday", locTextBox.Text);
        }

        private void ProvideFileInfo(string raidDay, string fileLoc)
        {
            string fileName = fileLoc; // need to trim this based on... the slashes? Can I get everything to the left of .layout and to the right of the last /?

            Layout layout = new Layout();
            layout.EditXMLForRaidDay(raidDay, fileName);
        }
    }
}