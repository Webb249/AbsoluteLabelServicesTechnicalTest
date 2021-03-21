using AbsoluteLabelServicesTechnicalTest.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace AbsoluteLabelServicesTechnicalTest.Services
{
    public class ItunesJSONReader : IResultsReader
    {

        /// <summary>
        /// Convert the string input into a list of structs
        /// </summary>
        /// <param name="results"></param>
        /// <returns>Requested values</returns>
        public List<EntityTypeStorage> GetRequestedResults(string results)
        {
            List<EntityTypeStorage> info = new List<EntityTypeStorage>();
            // Convert the results into a controllerable state
            Dictionary<string, object> dictResults = ConvertJsonToDict(results);

            // Comvert only the actual results of the search into the struct
            info = JsonConvert.DeserializeObject<List<EntityTypeStorage>>(dictResults["results"].ToString());
            
            return info;
        }

        /// <summary>
        /// Loop through all levels of the json string and convert to a Dictionary
        /// </summary>
        /// <param name="json"></param>
        /// <returns>Dicitionary of object values</returns>
        private Dictionary<string, object> ConvertJsonToDict(string json)
        {
            Dictionary<string, object> deserializedJson = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
            Dictionary<string, object> valuesDict = new Dictionary<string, object>();
            foreach (KeyValuePair<string, object> d in deserializedJson)
            {
                if (d.Value is JObject)
                {
                    valuesDict.Add(d.Key, ConvertJsonToDict(d.Value.ToString()));
                }
                else
                {
                    valuesDict.Add(d.Key, d.Value);
                }
            }
            return valuesDict;
        }
    }
}