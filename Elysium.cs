using System.Text.Json;

namespace Elysium
{
    internal class Elysium
    {
        public static Elysium? Get(string url = "https://nzx.hu/elysium/api.json")
        {
            HttpClient client = new HttpClient();
            return JsonSerializer.Deserialize<Elysium>(client.GetStringAsync(url).Result);
        }
        public List<PluginData>? jenkinsPlugins {  get; set; }
    }
    public class PluginData
    {
        public string? name { get; set; }
        public string? url { get; set; }
    }
}