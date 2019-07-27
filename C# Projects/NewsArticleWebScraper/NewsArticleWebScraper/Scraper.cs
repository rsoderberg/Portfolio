using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using NLog;

namespace NewsArticleWebScraper
{
    class Scraper
    {
        public string[] QueryTerms { get; } = {
            "Intro", "Tutorial", "Education", "Learn",
            "C#", "CSharp", "Neural", "IoT", "Simulation", "Software", "Robot",
            "Green", "Animal", "Hagfish", "Nature",
            "Communication", "Language", "Translation", "French", "Français"
        };

        public static Dictionary<string, string> savedArticles = new Dictionary<string, string> { };

        internal readonly NameValueCollection _appSettings = ConfigurationManager.AppSettings;
        internal static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public async void ScrapeHackerRank()
        {
            _logger.Log(LogLevel.Trace, $"URL: {_appSettings["HackerRankUrl"]}");

            CancellationTokenSource cancellationToken = new CancellationTokenSource();
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage request = await httpClient.GetAsync(_appSettings["HackerRankUrl"]);
            _logger.Log(LogLevel.Trace, $"Request: {request}");

            cancellationToken.Token.ThrowIfCancellationRequested();

            Stream response = await request.Content.ReadAsStreamAsync();
            _logger.Log(LogLevel.Trace, $"Response: {response}");

            cancellationToken.Token.ThrowIfCancellationRequested();
            
            HtmlParser parser = new HtmlParser();
            IHtmlDocument document = parser.ParseDocument(response);
            _logger.Log(LogLevel.Trace, $"Document: {document}");

            GetScrapeResults(QueryTerms, document);
        }

        private void GetScrapeResults(string[] queryTerms, IHtmlDocument document)
        {
            IEnumerable<IElement> storyLink;
            foreach (var term in queryTerms)
            {
                storyLink = document.All.Where(x => x.ClassName == "storylink" && (x.InnerHtml.Contains(term) || x.InnerHtml.Contains(term.ToLower())));
                _logger.Log(LogLevel.Trace, $"Number of links found: {storyLink.Count()}");

                if (storyLink.Any())
                {
                    Results results = new Results();
                    results.PrintResultsToResultsTextbox(term, storyLink);
                    results.SaveResultsForWeeklyEmail(term, storyLink);
                }
            }
        }
    }
}