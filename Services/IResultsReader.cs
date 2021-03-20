

using AbsoluteLabelServicesTechnicalTest.Models;
using System.Collections.Generic;

namespace AbsoluteLabelServicesTechnicalTest.Services
{
    public interface IResultsReader
    {
        List<EntityTypeStorage> GetRequestedResults(string results);
    }
}
