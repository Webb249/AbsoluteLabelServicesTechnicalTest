using AbsoluteLabelServicesTechnicalTest.Services;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace AbsoluteLabelServicesTechnicalTest.Models
{
    public class HomeModel
    {
        public IConfiguration configuration;

        private List<EntityTypeStorage> resultsList = new List<EntityTypeStorage>();
        public List<EntityTypeStorage> ResultsList 
        {
            get { return Utilities.RemoveOutDatedValues(resultsList, configuration); }
            set { resultsList = value; }
        
        }
    }
}
