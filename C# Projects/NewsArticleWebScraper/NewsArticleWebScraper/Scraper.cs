using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
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
            "Intro", "Tutorial", "Education", "Learn", "Book",
            "C#", "CSharp", "Software", "Developer", "Code",
            "Neural", "IoT", "Simulation", "Robot",
            "Hack", "Cyber", "Security",
            "Communication", "Language", "Translation", "French", "Français",
            "Green", "Animal", "Nature", "Climate", "Pollution", "Sea", "Population",
            "Martial Arts", "Muay Thai", "Kickboxing", "Kali", "Escrima",
            "Austin", "Texas"
        };

        public static Dictionary<string, string> SavedArticles = new Dictionary<string, string> { };

        private static WebScraperForm _form = WebScraperForm.ProcessMonitor;
        internal readonly NameValueCollection _appSettings = ConfigurationManager.AppSettings;
        internal static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        internal async void ScrapeHackerNews()
        {
            _logger.Log(LogLevel.Trace, $"URL: {_appSettings["HackerNewsUrl"]}");

            try
            {
                CancellationTokenSource cancellationToken = new CancellationTokenSource();
                HttpClient httpClient = new HttpClient();
                HttpResponseMessage request =
                    await httpClient.GetAsync(_appSettings["HackerNewsUrl"], cancellationToken.Token);
                ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                _logger.Log(LogLevel.Trace, $"Request: {request}");

                cancellationToken.Token.ThrowIfCancellationRequested();

                Stream response = await request.Content.ReadAsStreamAsync();
                _logger.Log(LogLevel.Trace, $"Response: {response}");

                cancellationToken.Token.ThrowIfCancellationRequested();

                HtmlParser parser = new HtmlParser();
                IHtmlDocument document = parser.ParseDocument(response);
                _logger.Log(LogLevel.Trace, $"Document: {document}");

                GetHackerNewsScrapeResults(document);
            }
            catch (Exception e)
            {
                _form.UpdateTextBox($"There was an error getting scrape results:{Environment.NewLine}{e}{Environment.NewLine}");
            }
        }

        private void GetHackerNewsScrapeResults(IHtmlDocument document)
        {
            IEnumerable<IElement> articleLink;
            foreach (var term in QueryTerms)
            {
                articleLink = document.All.Where(x => x.ClassName == "storylink" && (x.InnerHtml.Contains(term) || x.InnerHtml.Contains(term.ToLower())));
                _logger.Log(LogLevel.Trace, $"Number of links found: {articleLink.Count()}");

                if (articleLink.Any())
                {
                    HackerNewsResults hackerNews = new HackerNewsResults();
                    hackerNews.PrintToResultsTextbox(term, articleLink);

                    ResultsFile results = new ResultsFile();

                    if (!results.FileExists())
                    {
                        results.CreateFile();
                    }

                    results.WriteToFile();
                }
            }
        }

        internal async void ScrapeOceanNetworks()
        {
            _logger.Log(LogLevel.Trace, $"URL: {_appSettings["OceanNetworksUrl"]}");

            CancellationTokenSource cancellationToken = new CancellationTokenSource();
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage request = await httpClient.GetAsync(_appSettings["OceanNetworksUrl"]);
            _logger.Log(LogLevel.Trace, $"Request: {request}");

            cancellationToken.Token.ThrowIfCancellationRequested();

            Stream response = await request.Content.ReadAsStreamAsync();
            _logger.Log(LogLevel.Trace, $"Response: {response}");

            cancellationToken.Token.ThrowIfCancellationRequested();

            HtmlParser parser = new HtmlParser();
            IHtmlDocument document = parser.ParseDocument(response);
            _logger.Log(LogLevel.Trace, $"Document: {document}");

            GetOceanNetworksScrapeResults(document);
        }

        private void GetOceanNetworksScrapeResults(IHtmlDocument document)
        {
            IEnumerable<IElement> articleLink;
            foreach (var term in QueryTerms)
            {
                articleLink = document.All.Where(x => x.ClassName == "views-field views-field-nothing" && (x.ParentElement.InnerHtml.Contains(term) || x.ParentElement.InnerHtml.Contains(term.ToLower())));
                _logger.Log(LogLevel.Trace, $"Number of links found: {articleLink.Count()}");

                if (articleLink.Any())
                {
                    OceanNetworkResults results = new OceanNetworkResults();
                    results.PrintResultsToResultsTextbox(term, articleLink);
                    results.SaveResultsForDailyEmail(term);
                }
            }
        }
    }
}