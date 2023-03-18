using System.Text.Json;

namespace Elysium
{
    public class projectController
    {
        public string? project_id { get; set; }
        public string? project_name { get; set; }
        public List<string>? version_groups { get; set; }
        public List<string>? versions { get; set; }
    }
    public class versionController
    {
        public string? project_id { get; set; }
        public string? project_name { get; set; }
        public string? version { get; set; }
        public List<int>? builds { get; set; }
    }
    public class versionBuildController
    {
        public string? project_id { get; set; }
        public string? project_name { get; set; }
        public int build { get; set; }
        public string? time { get; set; }
        public string? channel { get; set; }
        public bool promoted { get; set; }
        public List<Change>? changes { get; set; }
        public Downloads? downloads { get; set; }
    }
    public class Change
    {
        public string? commit { get; set; }
        public string? summary { get; set; }
        public string? message { get; set; }
    }
    public class Jar
    {
        public string? name { get; set; }
        public string? sha256 { get; set; }
    }
    public class Downloads
    {
        public Jar? application { get; set; }
        public Jar? mojang_mappings { get; set; }
    }
    public class Paper
    {
        private static HttpClient client = new();
        public static projectController? AllVersions()
        {
            string json = client.GetStringAsync("https://api.papermc.io/v2/projects/paper").Result;
            return JsonSerializer.Deserialize<projectController>(json);
        }
        public static versionController? Builds(object version)
        {
            string json = client.GetStringAsync("https://api.papermc.io/v2/projects/paper/versions/" + version).Result;
            return JsonSerializer.Deserialize<versionController>(json);
        }
        public static versionBuildController? BuildInfo(object version, object build)
        {
            string json = client.GetStringAsync("https://api.papermc.io/v2/projects/paper/versions/" + version + "/builds/" + build).Result;
            return JsonSerializer.Deserialize<versionBuildController>(json.Replace("mojang-mappings", "mojang_mappings"));
        }
        public static byte[] Download(object version, object build, object file)
        {
            return client.GetByteArrayAsync("https://api.papermc.io/v2/projects/paper/versions/" + version + "/builds/" + build + "/downloads/" + file).Result;
        }
    }
}
