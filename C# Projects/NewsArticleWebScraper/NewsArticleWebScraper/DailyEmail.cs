using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace NewsArticleWebScraper
{
    class DailyEmail : Scraper
    {
        internal static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        internal void CreateEmailWithLastWeeksResults()
        {
            var yesterdaysDate = DateTime.Today.AddDays(-1);

            string subject = $"{yesterdaysDate} Scrape Results";
            string body = "";

            if (SavedArticles.Any())
            {
                foreach (var article in SavedArticles)
                {
                    body += $"{article.Key} - {article.Value}{Environment.NewLine}{Environment.NewLine}";
                }
            }
            else
            {
                body = $"No results found for queries:{Environment.NewLine}";
                foreach (var query in QueryTerms)
                    body += $"{query}";
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
