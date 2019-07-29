using System;
using System.Windows.Forms;

namespace NewsArticleWebScraper
{
    public partial class WebScraperForm : Form
    {
        public static WebScraperForm ProcessMonitor;
        private int _timeLeft;

        public WebScraperForm()
        {
            InitializeComponent();
            ProcessMonitor = this;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (startButton.Text == "Start")
            {
                _timeLeft = 120;
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

                ClearTextBoxWhenFull();

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
                    bool emailSent = false;
                    while (!emailSent)
                    {
                        DailyEmail email = new DailyEmail();
                        if (!emailSent && DateTime.Now.Hour == 7 && DateTime.Now.Minute == 00)
                            email.CreateEmailWithLastWeeksResults();

                        emailSent = true;
                    }
                }
                catch (Exception ex)
                {
                    UpdateTextBox($"Daily Email Error:{Environment.NewLine}{ex}");
                }

                _timeLeft = 120;
                timerLabel.Text = Convert.ToString(_timeLeft);
            }
        }

        private void ClearTextBoxWhenFull()
        {
            if (resultsTextbox.Text.Length >= resultsTextbox.MaxLength - 1)
            {
                resultsTextbox.Clear();
                UpdateTextBox(DateTime.Now + ": Cleared textbox!");
            }
        }
    }
}
