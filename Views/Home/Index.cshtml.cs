using Microsoft.AspNetCore.Mvc.RazorPages;
using AbsoluteLabelServicesTechnicalTest.Models;


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
    }
}
