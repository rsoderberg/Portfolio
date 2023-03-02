using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using System.Net;

namespace DDOBuilderUpdater
{
    public partial class UpdaterForm : Form
    {
        public UpdaterForm()
        {
            InitializeComponent();

            RunUpdater();
        }

        private async void RunUpdater()
        {
            // https://api.github.com/repos/Maetrim/DDOBuilder
            // https://api.github.com/repos/Maetrim/DDOBuilder/releases
            // https://social.msdn.microsoft.com/Forums/en-US/971b092e-3c5f-4571-a2a6-4a0e20996c12/how-to-parse-html-string-in-c?forum=aspwebforms


            using (WebClient client = new WebClient())
            {
                string versionId = "1.0.0.182"; // how to get this id?
                string shortVersion = "100182";
                string githubRepo = $"https://github.com/Maetrim/DDOBuilder/releases/download/{versionId}/DDOBuilder{shortVersion}.zip";
                string fileName = $"C:\\Users\\r_sod\\Downloads\\DDOBuilder{shortVersion}.zip";

                string releasesUrl = "https://api.github.com/repos/Maetrim/DDOBuilder/releases";

                // Will have to unzip file, then copy to DDO Builder folder

                try
                {
                    CancellationTokenSource cancellationToken = new CancellationTokenSource();
                    HttpClient httpClient = new HttpClient();
                    httpClient.DefaultRequestHeaders.Add("User-Agent", "C# App");

                    HttpResponseMessage request = await httpClient.GetAsync(releasesUrl, cancellationToken.Token);
                    ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                    cancellationToken.Token.ThrowIfCancellationRequested();

                    Stream response = await request.Content.ReadAsStreamAsync();
                    cancellationToken.Token.ThrowIfCancellationRequested();

                    HtmlParser parser = new HtmlParser();
                    IHtmlDocument document = parser.ParseDocument(response);

                    GetResults(document);
                }
                catch (Exception ex)
                {

                }




                
                try
                {
                    client.Headers.Add("user-agent", "Anything");
                    client.DownloadFile(githubRepo, fileName);

                    mainTextBox.AppendText($"Retrieved {githubRepo}");

                    // TODO: extract (fileName) from zip
                    // TODO: move inner files to DDO Builder location
                }
                catch (Exception ex)
                {
                    mainTextBox.AppendText($"Error: {ex}");
                }
            }
        }

        private void GetResults(IHtmlDocument document)
        {
            IEnumerable<IElement> links;
            links = document.All;

            if (links.Any())
            {
                foreach (var result in links)
                {
                    string htmlResult = result.OuterHtml;
                }
            }








            //string? myDoc = document.All[0].InnerHtml;



            //mainTextBox.AppendText($"Id found: {versionId.Count()}");
        }
    }
}