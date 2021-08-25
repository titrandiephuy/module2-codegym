using System.IO;
using Newtonsoft.Json;

namespace StudentsMana
{
    class FileHelper
    {
        public static T ReadFile<T>(string fullpath)
        {
            string data = string.Empty;
            using (StreamReader sr = File.OpenText(fullpath))
            {
                data = sr.ReadToEnd();
            }
        return JsonConvert.DeserializeObject<T>(data);
        }

        public static void WriteFile<T>(string fullpath, object data)
        {
            using (StreamWriter sw = File.CreateText(Path.Combine(fullpath)))
            {
                var jsonData = JsonConvert.SerializeObject(data);
                sw.Write(jsonData);
            }
        }
    }
}