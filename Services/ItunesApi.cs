using AbsoluteLabelServicesTechnicalTest.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AbsoluteLabelServicesTechnicalTest.Services
{
    public class ItunesApi : IApi
    {
        /// <summary>
        /// Get search results from web api
        /// </summary>
        /// <param name="searchphrase"></param>
        /// <param name="entity"></param>
        /// <returns>List of search results</returns>
        public async Task<List<EntityTypeStorage>> GetSearchResultsAsync(string searchphrase, string entity)
        {
            ISearcher searcher = new ItunesSearcher();
            IWebReader webReader = new WebReader();
            IResultsReader jSONReader = new ItunesJSONReader();

            searcher.SetSearchValues(searchphrase, entity);
            webReader.SetWebURL(searcher.GetSearchAddress());

            string results = await webReader.GetSearchResultsAsync();

            List<EntityTypeStorage> requestedResults = jSONReader.GetRequestedResults(results);

            return requestedResults;
        }
    }
}
