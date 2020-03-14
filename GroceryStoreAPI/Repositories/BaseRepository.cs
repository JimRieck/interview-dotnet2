using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace GroceryStoreAPI.Repositories
{
    public class BaseRepository
    {
        protected dynamic ReadDataFromFile(string tableName)
        {
            var myJsonString = File.ReadAllText("database.json");
            JObject rss = JObject.Parse(myJsonString);

           

            dynamic jsonObj = JsonConvert.DeserializeObject(myJsonString);
            return jsonObj[tableName];
        }
    }
}
