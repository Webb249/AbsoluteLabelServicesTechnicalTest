
using AbsoluteLabelServicesTechnicalTest.Services;
using System;

namespace AbsoluteLabelServicesTechnicalTest.Models
{
    public struct EntityTypeStorage
    {
        public string artistName { get; set; }
        public string trackName { get; set; }

        private DateTime releaseDateTime;
        public string releaseDate 
        { 
            get { return Utilities.ConvertDateToLocalFormat(releaseDateTime); } 
            set { releaseDateTime = DateTime.Parse(value); }
        }

        public string artworkUrl100 { get; set; }
    }
}
