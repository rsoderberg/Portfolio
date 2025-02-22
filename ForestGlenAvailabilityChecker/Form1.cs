using System.Collections.Specialized;
using System.Configuration;

namespace ForestGlenAvailabilityChecker
{
    public partial class CheckForm : Form
    {
        public static CheckForm ProcessMonitor;

        internal readonly NameValueCollection _appSettings = ConfigurationManager.AppSettings;

        private int _timeLeft;
        private int _timerMax;

        public CheckForm()
        {
            InitializeComponent();
            ProcessMonitor = this;
            _timerMax = Convert.ToInt32(_appSettings["TimerMax"]);
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

                ScrapeWebsite();
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

                _timeLeft = _timerMax;
                timerLabel.Text = Convert.ToString(_timeLeft);
            }
        }

        private void ScrapeWebsite()
        {
            bool isBusinessHours = (DateTime.Now.Hour >= 8 && DateTime.Now.Hour <= 18) && DateTime.Now.DayOfWeek != DayOfWeek.Sunday;

            if (isBusinessHours)
            {
                Scraper scraper = new Scraper();
                scraper.ScrapeForestGlenFloorPlans();
            }
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
