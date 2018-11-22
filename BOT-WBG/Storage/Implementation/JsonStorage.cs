using System;
using System.IO;
using Newtonsoft.Json;
using static System.IO.Directory;
using System.Collections.Generic;
using System.Text;

namespace BOT_WBG.Storage.Implementation
{
    public class JsonStorage : IDateStorage
    {
        public T RestoreObject<T>(string key)
        {
            var json = File.ReadAllText($"{key}.json");
            return JsonConvert.DeserializeObject<T>(json);
        }

        public void StoreObject(object obj, string key)
        {
            var file = $"{key}.json";
            CreateDirectory(Path.GetDirectoryName(file));
            var json = JsonConvert.SerializeObject(obj);
            File.WriteAllText(file, json);

        }
    }
}
