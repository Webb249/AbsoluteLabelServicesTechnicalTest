
using System.Net;

namespace AbsoluteLabelServicesTechnicalTest.Models
{
    public class WebReader : IWebReader
    {
        private string _URL = "";

        public void SetWebURL(string URL)
        {
            this._URL = URL;
        }

        public string GetSearchResults()
        {
            string searchResult = "";

            // Replace spaces with "+" to format the string correctly for the URL search request
            string formattedString = _URL.Replace(" ", "+");

            using (WebClient webClient = new WebClient())
            {
                searchResult = webClient.DownloadString(formattedString);
            }

            return searchResult;
        }
    }
}
