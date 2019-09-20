using System;
using System.IO;

namespace NewsArticleWebScraper
{
    class ResultsFile : Scraper
    {
        private readonly string FileLocation = $@".\Articles\{DateTime.Now.Month}{DateTime.Now.Day}{DateTime.Now.Year}_NewsArticles.txt";

        private static WebScraperForm _form = WebScraperForm.ProcessMonitor;

        internal bool FileExists()
        {
            return File.Exists(FileLocation) ? true : false;
        }

        internal void CreateFile()
        {
            var file = File.Create(FileLocation);
            file.Close();
        }

        internal void WriteToFile()
        {
            if (!SavedArticles.ContainsKey(_form.Title) && !SavedArticles.ContainsValue(_form.Url))
            {
                SavedArticles.Add(_form.Title, _form.Url); // Doing this to avoid duplicate results, instead of reading through the file every time I want to write

                using (StreamWriter file = File.AppendText(FileLocation))
                {
                    file.WriteLine($"{_form.Title} - {_form.Url}{Environment.NewLine}");
                    file.Close();
                }
            }
        }

        internal string[] ReadLinesFromFile()
        {
            string[] lines = File.ReadAllLines(FileLocation);
            return lines;
        }
    }
}
