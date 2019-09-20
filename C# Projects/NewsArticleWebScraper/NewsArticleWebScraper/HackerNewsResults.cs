using AngleSharp.Dom;
using AngleSharp.Text;
using NLog;
using System;
using System.Collections.Generic;

namespace NewsArticleWebScraper
{
    class HackerNewsResults : Scraper
    {
        private static WebScraperForm _form  = WebScraperForm.ProcessMonitor;
        internal static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public void PrintToResultsTextbox(string term, IEnumerable<IElement> articleLink)
        {
            foreach (var result in articleLink)
            {
                CleanUpResultsAndSplitIntoTitleAndUrl(result);

                _form.UpdateTextBox($"{_form.Title} - {_form.Url}{Environment.NewLine}");
            }

            _form.UpdateTextBox($"-----{term}-----");
        }

        private void CleanUpResultsAndSplitIntoTitleAndUrl(IElement result)
        {
            _logger.Log(LogLevel.Trace, $"Inner HTML Result: {result}");

            string htmlResult = result.OuterHtml.ReplaceFirst("<a href=\"", "");
            htmlResult = htmlResult.ReplaceFirst("\" class=\"storylink\">", "*");
            htmlResult = htmlResult.ReplaceFirst("\" class=\"storylink\" rel=\"nofollow\">", "*");
            htmlResult = htmlResult.ReplaceFirst("</a>", "");

            string[] splitResults = htmlResult.Split('*');
            _form.Url = splitResults[0];
            _form.Title = splitResults[1];

            _logger.Log(LogLevel.Trace, $"Title: {_form.Title}, URL: {_form.Url}");
        }
    }
}
