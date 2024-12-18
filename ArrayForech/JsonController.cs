using System.IO;
using Newtonsoft.Json;
//using System.Text.Json;

namespace ArrayForech
{
    class JsonController
    {
        private const string nameJsonFile = "json.json";
        
        public Json JsonStart()
        {
            //var Json = new Json();
            var Json = File.Exists(nameJsonFile) ? JsonConvert.DeserializeObject<Json>(File.ReadAllText(nameJsonFile)) : new Json();

            string objectSerialized = System.Text.Json.JsonSerializer.Serialize(Json, typeof(Json));
            File.WriteAllText(nameJsonFile, objectSerialized);
            return Json;
        }

        public void JsonSave(Json json)
        {
            File.WriteAllText(nameJsonFile, JsonConvert.SerializeObject(json));
        }
    }
}
