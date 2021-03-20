
namespace AbsoluteLabelServicesTechnicalTest.Models
{
    /// <summary>
    /// Interface for the different systems to be used in a search
    /// </summary>
    public interface ISearchType
    {
        // Set the search values to be used
        void SetSearchValues(string searchValue, string entity);

        // Return the API address
        string GetSearchAddress();
    }
}
