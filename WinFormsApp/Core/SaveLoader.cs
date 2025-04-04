using System.Text.Json;

namespace WinFormsApp
{
    public class SaveLoader
    {
        public static void Save<T>(List<T> obj, string filePath)
        {
            using (var fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                JsonSerializer.Serialize<List<T>>(fs, obj);
        }

        public static List<T> Load<T>(string filePath)
        {
            using (var fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read))
                return JsonSerializer.Deserialize<List<T>>(fs);
        }
    }
}