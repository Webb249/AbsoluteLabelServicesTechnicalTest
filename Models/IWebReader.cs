﻿
namespace AbsoluteLabelServicesTechnicalTest.Models
{
    /// <summary>
    /// Interface for the client communcations
    /// </summary>
    public interface IWebReader
    {
        // Set the address to be used in the search
        void SetWebURL(string URL);
        // Run and return the Search results
        string GetSearchResults();
    }
}
