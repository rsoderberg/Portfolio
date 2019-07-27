using System;
using System.Collections.Generic;
using AngleSharp.Dom;
using AngleSharp.Text;
using NLog;

namespace NewsArticleWebScraper
{
    class HackerNewsResults : Scraper
    {
        private string Url { get; set; }
        private string Title { get; set; }

        internal static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public void PrintResultsToResultsTextbox(string term, IEnumerable<IElement> articleLink)
        {
            foreach (var result in articleLink)
            {
                CleanUpResultsAndSplitIntoTitleAndUrl(result);

                WebScraperForm.ProcessMonitor.UpdateTextBox($"{Title} - {Url}{Environment.NewLine}");
            }

            WebScraperForm.ProcessMonitor.UpdateTextBox($"-----{term}-----");
        }

        private void CleanUpResultsAndSplitIntoTitleAndUrl(IElement result)
        {
            _logger.Log(LogLevel.Trace, $"Inner HTML Result: {result}");

            string htmlResult = result.OuterHtml.ReplaceFirst("<a href=\"", "");
            htmlResult = htmlResult.ReplaceFirst("\" class=\"storylink\">", "*");
            htmlResult = htmlResult.ReplaceFirst("\" class=\"storylink\" rel=\"nofollow\">", "*");
            htmlResult = htmlResult.ReplaceFirst("</a>", "");

            string[] splitResults = htmlResult.Split('*');
            Url = splitResults[0];
            Title = splitResults[1];

            _logger.Log(LogLevel.Trace, $"Title: {Title}, URL: {Url}");
        }

        public void SaveResultsForWeeklyEmail(string term)
        {
            if (!savedArticles.ContainsKey(Title) && !savedArticles.ContainsValue(Url))
                savedArticles.Add(Title, Url);
        }

    }
}
