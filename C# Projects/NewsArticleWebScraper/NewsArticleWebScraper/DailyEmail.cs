using NLog;
using System;

namespace NewsArticleWebScraper
{
    class DailyEmail : Scraper
    {
        internal static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        internal void CreateEmailWithPreviousDaysResults()
        {
            var yesterdaysDate = DateTime.Today.AddDays(-1).Date;

            string subject = $"{yesterdaysDate} Scrape Results";
            string body = "";

            ResultsFile results = new ResultsFile();

            if (results.FileExists())
            {
                string[] lines = results.ReadLinesFromFile();

                foreach (var line in lines)
                {
                    body += $"{line}{Environment.NewLine}{Environment.NewLine}";
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
            WebScraperForm.ProcessMonitor.ClearTextBox();
        }

        private void ClearSavedArticles()
        {
            SavedArticles.Clear();
        }
    }
}
