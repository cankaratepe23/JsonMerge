using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace JsonMerge
{
    internal class JsonParseCompareEngine
    {
        public JsonParseCompareEngine(string originalFilePath, string compareFilePath)
        {
            OriginalFilePath = originalFilePath;
            CompareFilePath = compareFilePath;
        }

        public string OriginalFilePath { get; set; }
        public string CompareFilePath { get; set; }
        public Dictionary<string, object> OriginalDict { get; set; }
        public Dictionary<string, object> CompareDict { get; set; }

        public void Load()
        {
            {
                var originalString = File.ReadAllText(OriginalFilePath);
                OriginalDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(originalString);
            }
            {
                var compareString = File.ReadAllText(CompareFilePath);
                CompareDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(compareString);
            }
        }

        public void GenerateMergedJson(string savePath)
        {
            var mergedKeysDict = new Dictionary<string, object>();
            foreach (var originalKvp in OriginalDict)
                mergedKeysDict.Add(originalKvp.Key,
                    !CompareDict.ContainsKey(originalKvp.Key) ? originalKvp.Value : CompareDict[originalKvp.Key]);

            File.WriteAllText(savePath, JsonConvert.SerializeObject(mergedKeysDict, Formatting.Indented));
        }
    }
}