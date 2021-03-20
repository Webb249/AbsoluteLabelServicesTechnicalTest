

using System.Collections.Generic;

namespace AbsoluteLabelServicesTechnicalTest.Models
{
    public interface IResultsReader
    {
        List<EntityTypeStorage> GetRequestedResults(string results);
    }
}
