using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using Microsoft.Toolkit.Uwp.Notifications;
using System.Collections.Specialized;
using System.Configuration;
using System.Net;

namespace ForestGlenAvailabilityChecker
{
    internal class Scraper
    {
        private static CheckForm _form = CheckForm.ProcessMonitor;
        internal readonly NameValueCollection _appSettings = ConfigurationManager.AppSettings;

        internal void ScrapeForestGlenFloorPlans()
        {
            string webURL = _appSettings["ForestGlenURL"];

            try
            {
                CookieContainer cookies = new CookieContainer();
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(webURL);
                request.Proxy.Credentials = CredentialCache.DefaultCredentials;
                request.Method = "GET";
                request.CookieContainer = cookies;
                request.UserAgent = _appSettings["UserAgent"];
                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        string html = streamReader.ReadToEnd();

                        HtmlParser parser = new HtmlParser();
                        IHtmlDocument document = parser.ParseDocument(html);

                        IElement? availability = document.All.FirstOrDefault(x => x.ClassName == "primary-action" && x.OuterHtml.Contains("Spruce") && !x.InnerHtml.Contains("Get Notified")); 
                        if (availability != null)
                        {
                            string toastMemo = $"Your floor plan is available for move-in: {availability.InnerHtml}";

                            new ToastContentBuilder()
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(toastMemo)
                                .Show();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                _form.UpdateTextBox($"There was an error getting scrape results:{Environment.NewLine}{e}{Environment.NewLine}");
            }
        }
    }
}