using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace NewsArticleWebScraper
{
    class WeeklyEmail : Scraper
    {
        internal static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        internal void CreateEmailWithLastWeeksResults()
        {
            string subject = "Last Week's Scrape Results";
            string body = "";

            if (savedArticles.Any())
            {
                foreach (var article in savedArticles)
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
        }
    }
}
