using AbsoluteLabelServicesTechnicalTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            ISearcher searchType = new ItunesSearcher();
            IWebReader webReader = new WebReader();
            IResultsReader jSONReader = new ItunesJSONReader();

            searchType.SetSearchValues(searchphrase, entity);
            webReader.SetWebURL(searchType.GetSearchAddress());

            string results = await webReader.GetSearchResultsAsync();

            List<EntityTypeStorage> requestedResults = jSONReader.GetRequestedResults(results);

            return requestedResults;
        }
    }
}
