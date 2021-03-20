
using System.Collections.Generic;

namespace AbsoluteLabelServicesTechnicalTest.Services
{
    /// <summary>
    /// Contains the entity types used with the search
    /// </summary>
    public static class SearchEntities
    {
        // List of entity types itunes supports
        public enum iTunes
        {
            Movie,
            Podcast,
            Music,
            MusicVideo,
            AudioBook,
            ShortFilm,
            TVShow,
            Software,
            Ebook
        }

        // Entities and their actual value to be used in the search
        public static Dictionary<string, string> iTunesEntityRelationship = new Dictionary<string, string> {
            { "Movie", "movie" },
            { "Podcast", "podcast" },
            { "Music", "musicTrack" },
            { "MusicVideo", "musicVideo" },
            { "AudioBook", "audiobook" },
            { "ShortFilm", "shortFilm" },
            { "TVShow", "tvSeason" },
            { "Software", "software" },
            { "Ebook", "ebook" }
        };
    }
}
