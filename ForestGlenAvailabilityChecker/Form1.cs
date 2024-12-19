namespace ForestGlenAvailabilityChecker
{
    public partial class CheckForm : Form
    {
        public static CheckForm ProcessMonitor;

        private string Title { get; set; }
        private string Url { get; set; }

        private int _timeLeft;
        private bool _emailSent;
        private int _timerMax = 30;

        public CheckForm()
        {
            InitializeComponent();
            ProcessMonitor = this;
        }

        private void CheckForm_Shown(object sender, EventArgs e)
        {
            startButton_Click(this, EventArgs.Empty);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (startButton.Text == "Start")
            {
                _timeLeft = _timerMax;
                timerLabel.Text = Convert.ToString(_timeLeft);

                timer1.Start();
                startButton.Text = "Stop";

                //ScrapeWebsite();
            }
            else
            {
                timer1.Stop();
                startButton.Text = "Start";
            }
        }

        public void UpdateTextBox(string processorMessage)
        {
            resultsTextbox.Text = processorMessage + Environment.NewLine + resultsTextbox.Text;
            resultsTextbox.Update();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_timeLeft > 1)
            {
                _timeLeft -= 1;
                timerLabel.Text = Convert.ToString(_timeLeft);
            }
            else
            {
                if (resultsTextbox.Text.Length >= 100000)
                    resultsTextbox.Text = resultsTextbox.Text.Substring(0, 100000);

                HandleTextBoxFull();

                try
                {
                    ScrapeWebsite();
                }
                catch (Exception ex)
                {
                    UpdateTextBox($"Scraping Error:{Environment.NewLine}{ex}");
                }

                try
                {
                    Email email = new Email();
                    email.BuildEmail("Test", "This is a test email");
                }
                catch (Exception ex)
                {
                    UpdateTextBox($"Daily Email Error:{Environment.NewLine}{ex}");
                }

                _timeLeft = _timerMax;
                timerLabel.Text = Convert.ToString(_timeLeft);
            }
        }

        private void ScrapeWebsite()
        {
            Scraper scraper = new Scraper();
            //scraper.ScrapeHackerNews();
        }

        private void HandleTextBoxFull()
        {
            if (resultsTextbox.Text.Length >= resultsTextbox.MaxLength - 20)
            {
                ClearTextBox();
            }
        }

        public void ClearTextBox()
        {
            resultsTextbox.Clear();
        }
    }
}
