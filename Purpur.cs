using System.Text.Json;

namespace Elysium
{
    public class purpurVersions
    {
        public string? project { get; set; }
        public List<string>? versions { get; set; }
    }
    public class purpurVersion
    {
        public purpurBuilds? builds { get; set; }
        public string? project { get; set; }
        public string? version { get; set; }
    }
    public class purpurBuilds
    {
        public List<string>? all { get; set; }
        public string? latest { get; set; }
    }
    public class purpurBuild
    {
        public string? build { get; set; }
        public List<purpurCommit>? commits { get; set; }
        public int? duration { get; set; }
        public string? md5 { get; set; }
        public string? project { get; set; }
        public string? result { get; set; }
        public long? timestamp { get; set; }
        public string? version { get; set; }
        public byte[] Download()
        {
            return Purpur.client.GetByteArrayAsync("https://api.purpurmc.org/v2/purpur/" + version + "/" + build + "/download").Result;
        }
    }
    public class purpurCommit
    {
        public string? author { get; set; }
        public string? description { get; set; }
        public string? email { get; set; }
        public string? hash { get; set; }
        public long? timestamp { get; set; }
    }
    public class Purpur
    {
        public static HttpClient client = new();
        public static purpurVersions? AllVersions()
        {
            string json = client.GetStringAsync("https://api.purpurmc.org/v2/purpur").Result;
            return JsonSerializer.Deserialize<purpurVersions>(json);
        }
        public static purpurVersion? Builds(object version)
        {
            string json = client.GetStringAsync("https://api.purpurmc.org/v2/purpur/" + version).Result;
            return JsonSerializer.Deserialize<purpurVersion>(json);
        }
        public static purpurBuild? BuildInfo(object version, object build)
        {
            string json = client.GetStringAsync("https://api.purpurmc.org/v2/purpur/" + version + "/" + build).Result;
            return JsonSerializer.Deserialize<purpurBuild>(json);
        }
    }
}
