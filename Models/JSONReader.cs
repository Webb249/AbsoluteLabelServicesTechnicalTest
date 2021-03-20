using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace AbsoluteLabelServicesTechnicalTest.Models
{
    public class JSONReader : IResultsReader
    {

        public List<EntityTypeStorage>GetRequestedResults(string results)
        {
            List<EntityTypeStorage> info = new List<EntityTypeStorage>();
            // Convert the results into a controllerable state
            Dictionary<string, object> dictResults = ConvertJsonToDict(results);

            // Comvert only the actual results of the search into the struct
            info = JsonConvert.DeserializeObject<List<EntityTypeStorage>>(dictResults["results"].ToString());
            
            return info;
        }

        private Dictionary<string, object> ConvertJsonToDict(string jo)
        {
            var values = JsonConvert.DeserializeObject<Dictionary<string, object>>(jo);
            var values2 = new Dictionary<string, object>();
            foreach (KeyValuePair<string, object> d in values)
            {
                if (d.Value is JObject)
                {
                    values2.Add(d.Key, ConvertJsonToDict(d.Value.ToString()));
                }
                else
                {
                    values2.Add(d.Key, d.Value);
                }
            }
            return values2;
        }
    }
}