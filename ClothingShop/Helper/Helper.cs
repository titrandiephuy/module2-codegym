using System.IO;
using Newtonsoft.Json;

namespace ClothingShop
{
    class Helper
    {
        public static T ReadFile<T>(string fullpath)
        {
            string responseData = string.Empty;
            using (StreamReader sr = File.OpenText(fullpath))
            {
                responseData = sr.ReadToEnd();
            }
            return JsonConvert.DeserializeObject<T>(responseData);
        }

        public static void WriteFile<T>(string fullpath, object modal)
        {
            using (StreamWriter sw = File.AppendText(Path.Combine(fullpath))){
                var jsonData = JsonConvert.SerializeObject(modal);
                sw.Write(jsonData);
            }
        }
    }
}