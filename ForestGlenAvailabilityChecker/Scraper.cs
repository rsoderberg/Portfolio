using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using System.Collections.Specialized;
using System.Configuration;
using System.Net;
using System.Windows.Forms;

namespace ForestGlenAvailabilityChecker
{
    internal class Scraper
    {
        public string[] QueryTerms { get; } = {
            "Intro", "Tutorial", "Education", "Learn", "Book",
            "C#", "CSharp", "Software", "Developer", "Code", "Salesforce",
            "Neural", "IoT", "Simulation", "Robot",
            "Hack", "Cyber", "Security",
            "Communication", "Translation", "French", "Français", "Mongolian",
            "Green", "Animal", "Nature", "Climate", "Pollution", "Sea"
        };

        public static Dictionary<string, string> SavedArticles = new Dictionary<string, string> { };

        private static CheckForm _form = CheckForm.ProcessMonitor;
        internal readonly NameValueCollection _appSettings = ConfigurationManager.AppSettings;

        internal async void ScrapeHackerNews()
        {
            try
            {
                CancellationTokenSource cancellationToken = new CancellationTokenSource();
                HttpClient httpClient = new HttpClient();
                HttpResponseMessage request = await httpClient.GetAsync(_appSettings["ForestGlenURL"], cancellationToken.Token);
                ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                _form.UpdateTextBox($"Request: {request}");

                cancellationToken.Token.ThrowIfCancellationRequested();

                Stream response = await request.Content.ReadAsStreamAsync();
                _form.UpdateTextBox($"Response: {response}");
                cancellationToken.Token.ThrowIfCancellationRequested();

                HtmlParser parser = new HtmlParser();
                IHtmlDocument document = parser.ParseDocument(response);
                _form.UpdateTextBox($"Document: {document}");

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
                _form.UpdateTextBox($"Number of links found: {articleLink.Count()}");

                if (articleLink.Any())
                {
                    // Notify of results
                }
            }
        }
    }
}