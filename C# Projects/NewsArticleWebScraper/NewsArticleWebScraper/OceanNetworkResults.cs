using AngleSharp.Dom;
using AngleSharp.Text;
using NLog;
using System;
using System.Collections.Generic;

namespace NewsArticleWebScraper
{
    class OceanNetworkResults : Scraper
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

            string htmlResult = result.InnerHtml.ReplaceFirst("        <span class=\"field-content\"><div><a href=\"", "https://www.oceannetworks.ca");
            htmlResult = htmlResult.ReplaceFirst("\">", "*");
            htmlResult = htmlResult.ReplaceFirst("</a></div>\n<div class=\"article-title-top\">", "-");
            htmlResult = htmlResult.ReplaceFirst("</div>\n<hr></span>  ", "");

            SplitResultsIntoTitleAndUrl(htmlResult);

            _logger.Log(LogLevel.Trace, $"Title: {Title}, URL: {Url}");
        }

        private void SplitResultsIntoTitleAndUrl(string htmlResult)
        {
            string[] splitResults = htmlResult.Split('*');
            Url = splitResults[0];
            Title = splitResults[1];
        }

        public void SaveResultsForWeeklyEmail(string term)
        {
            if (!savedArticles.ContainsKey(Title) && !savedArticles.ContainsValue(Url))
                savedArticles.Add(Title, Url);
        }
    }
}
