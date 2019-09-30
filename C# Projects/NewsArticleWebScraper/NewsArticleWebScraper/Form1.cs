using System;
using System.Windows.Forms;

namespace NewsArticleWebScraper
{
    public partial class WebScraperForm : Form
    {
        public static WebScraperForm ProcessMonitor;

        internal string Title { get; set; }
        internal string Url { get; set; }

        private int _timeLeft;
        private bool _emailSent;
        private int _timerMax = 30;

        public WebScraperForm()
        {
            InitializeComponent();
            ProcessMonitor = this;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (startButton.Text == "Start")
            {
                _timeLeft = _timerMax;
                timerLabel.Text = Convert.ToString(_timeLeft);

                timer1.Start();
                startButton.Text = "Stop";

                Scraper scraper = new Scraper();
                scraper.ScrapeHackerNews();
                //scraper.ScrapeOceanNetworks();
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
                    Scraper scraper = new Scraper();
                    scraper.ScrapeHackerNews();
                    //scraper.ScrapeOceanNetworks();
                }
                catch (Exception ex)
                {
                    UpdateTextBox($"Scraping Error:{Environment.NewLine}{ex}");
                }

                try
                {
                    if (!_emailSent)
                    {
                        DailyEmail email = new DailyEmail();
                        if (!_emailSent && DateTime.Now.Hour == 00 && DateTime.Now.Minute == 00)
                        {
                            email.CreateEmailWithPreviousDaysResults();
                            _emailSent = true;
                        }
                        else // Reset email check for next day
                        {
                            _emailSent = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    UpdateTextBox($"Daily Email Error:{Environment.NewLine}{ex}");
                }

                _timeLeft = _timerMax;
                timerLabel.Text = Convert.ToString(_timeLeft);
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
