using NLog;
using System;

namespace NewsArticleWebScraper
{
    class DailyEmail : Scraper
    {
        internal static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private static WebScraperForm _form = WebScraperForm.ProcessMonitor;

        internal void CreateEmailWithPreviousDaysResults()
        {
            string yesterdaysDate = $"{DateTime.Now.Month}{DateTime.Now.Day - 1}{DateTime.Now.Year}";

            string subject = $"{yesterdaysDate} Scrape Results";
            string body = "";

            ResultsFile results = new ResultsFile();

            if (results.FileExists(yesterdaysDate))
            {
                string[] lines = results.ReadLinesFromFile(yesterdaysDate);

                foreach (var line in lines)
                {
                    body += $"{line}{Environment.NewLine}";
                }
            }
            else
            {
                body = $"No results found for queries:{Environment.NewLine}";
                foreach (var query in QueryTerms)
                    body += $"{query} ";
            }

            Email email = new Email();
            email.BuildEmail(subject, body);

            ClearSavedArticles();
            _form.ClearTextBox();
        }

        private void ClearSavedArticles()
        {
            SavedArticles.Clear();
        }
    }
}
