using AbsoluteLabelServicesTechnicalTest.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AbsoluteLabelServicesTechnicalTest.Services
{
    public interface IApi
    {
        Task<List<EntityTypeStorage>> GetSearchResultsAsync(string searchphrase, string entity);
    }
}