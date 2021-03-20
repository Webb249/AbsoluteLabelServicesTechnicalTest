
using System;
using System.Net;
using System.Threading.Tasks;

namespace AbsoluteLabelServicesTechnicalTest.Services
{
    public class WebReader : IWebReader
    {
        private string _URL = "";

        public void SetWebURL(string URL)
        {
            this._URL = URL;
        }

        public async Task<string> GetSearchResultsAsync()
        {
            string searchResult = "";

            // Replace spaces with "+" to format the string correctly for the URL search request
            string formattedString = _URL.Replace(" ", "+");

            using (WebClient webClient = new WebClient())
            {
                searchResult = await webClient.DownloadStringTaskAsync(new Uri(formattedString));
            }

            return searchResult;
        }
    }
}
