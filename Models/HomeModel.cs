using System.Collections.Generic;

namespace AbsoluteLabelServicesTechnicalTest.Models
{
    public class HomeModel
    {
        // Results from the search stored as a string
        public List<EntityTypeStorage> ResultsList { get; set; } = new List<EntityTypeStorage>();
    }
}
