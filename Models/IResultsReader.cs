

using System.Collections.Generic;

namespace AbsoluteLabelServicesTechnicalTest.Models
{
    public interface IResultsReader
    {
        Dictionary<string, object> ConvertToResultsInfo(string results);
    }
}
