using Microsoft.AspNetCore.Mvc.RazorPages;
using AbsoluteLabelServicesTechnicalTest.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace IndexPageUI
{
    public class Index : PageModel
    {
        // User entered string to be used in the search
        public string SearchPhrase { get; set; }
        // Selected entity
        public string Entity { get; set; }
        // Store the list of entity types that can be used
        public SearchEntities.iTunes TypeList { get; set; }
        // Results from the search stored as a string
        public List<EntityTypeStorage> ResultsList { get; set; } = new List<EntityTypeStorage>();

        private ISearchType _searchType;
        private IWebReader _webReader;

        public Index(ISearchType searchType, IWebReader webReader)
        {
            this._searchType = searchType;
            this._webReader = webReader;
        }

        /// <summary>
        /// Get the search results
        /// </summary>
        public async Task RunGetSearchResults()
        {
            _searchType.SetSearchValues(SearchPhrase, Entity);
            _webReader.SetWebURL(_searchType.GetSearchAddress());

            string results = await Task.Run(() => { return _webReader.GetSearchResults(); });

            JSONReader jSONReader = new JSONReader();
            ResultsList = jSONReader.GetRequestedResults(results);
        }
    }
}
