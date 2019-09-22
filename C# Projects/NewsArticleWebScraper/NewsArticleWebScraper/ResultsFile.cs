using System;
using System.IO;

namespace NewsArticleWebScraper
{
    class ResultsFile : Scraper
    {
        private readonly string FileLocation = $@".\Articles\";
        private readonly string FileNameAppend = $"_NewsArticles.txt";
        private readonly string CurrentDate = $"{DateTime.Now.Month}{DateTime.Now.Day}{DateTime.Now.Year}";

        private static WebScraperForm _form = WebScraperForm.ProcessMonitor;

        internal bool FileExists(string date)
        {
            return File.Exists($"{FileLocation}{date}{FileNameAppend}") ? true : false;
        }

        internal void CreateFile()
        {
            var file = File.Create($"{FileLocation}{CurrentDate}{FileNameAppend}");
            file.Close();
        }

        internal void WriteToFile()
        {
            if (!SavedArticles.ContainsKey(_form.Title) && !SavedArticles.ContainsValue(_form.Url))
            {
                SavedArticles.Add(_form.Title, _form.Url); // Doing this to avoid duplicate results, instead of needing
                                                           // to read through the file every time I want to write to it

                using (StreamWriter file = File.AppendText($"{FileLocation}{CurrentDate}{FileNameAppend}"))
                {
                    file.WriteLine($"{_form.Title} - {_form.Url}{Environment.NewLine}");
                    file.Close();
                }
            }
        }

        internal string[] ReadLinesFromFile()
        {
            string[] lines = File.ReadAllLines($"{FileLocation}{CurrentDate}{FileNameAppend}");
            return lines;
        }
    }
}
