namespace AbsoluteLabelServicesTechnicalTest.Models
{
    /// <summary>
    /// ISearchType for the itunes api searching
    /// </summary>
    public class ItunesSearch : ISearchType
    {
        private string SearchAddress = "https://itunes.apple.com/search?";
        private string _value = "";
        private string _type = "";

        public void SetSearchValues(string value, string type)
        {
            this._value = value;
            this._type = type;
        }

        public string GetSearchAddress()
        {
            return ConstructAPIAddress();
        }

        // Construct the address to be used for the itunes API search
        private string ConstructAPIAddress()
        {
            return SearchAddress + "term=" + _value + "&country=GB" + "&entity=" + SearchEntities.iTunesEntityRelationship[_type];
        }
    }
}