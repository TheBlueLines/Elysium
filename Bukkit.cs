namespace Elysium
{
    public class ServerVersion
    {
        public string? name { get; set; }
        public string? url { get; set; }
        private HttpClient client = new();
        public byte[] Download()
        {
            string line = client.GetStringAsync(url).Result.Split('\n')[106];
            int startIndex = line.IndexOf('\"');
            int endIndex = line.IndexOf('\"', ++startIndex);
            url = line[startIndex..endIndex];
            return client.GetByteArrayAsync(url).Result;
        }
        public string getFileName()
        {
            string line = client.GetStringAsync(url).Result.Split('\n')[106];
            int startIndex = line.IndexOf('>', line.IndexOf('>') + 1);
            int endIndex = line.IndexOf('<', ++startIndex);
            return line[startIndex..endIndex].ToLower();
        }
    }
    internal class Bukkit
    {
        public static List<ServerVersion> spigotVersions = new();
        public static List<ServerVersion> bukkitVersions = new();
        private static HttpClient client = new();
        public static void LoadVersions(string? project = null)
        {
            if (project == null)
            {
                LoadVersions("spigot");
                LoadVersions("craftbukkit");
            }
            else if (project == "spigot")
            {
                spigotVersions = DoWork("https://getbukkit.org/download/spigot");
            }
            else if (project == "craftbukkit")
            {
                bukkitVersions = DoWork("https://getbukkit.org/download/craftbukkit");
            }
        }
        private static List<ServerVersion> DoWork(string url)
        {
            List<ServerVersion> versions = new();
            string[] lines = client.GetStringAsync(url).Result.Split('\n');
            int start = 104;
            while (true)
            {
                if (lines[start].StartsWith("<h2>"))
                {
                    int startIndex = lines[start + 13].IndexOf('\"');
                    int endIndex = lines[start + 13].IndexOf('\"', ++startIndex);
                    versions.Add(new ServerVersion()
                    {
                        name = lines[start][4..^5],
                        url = lines[start + 13][startIndex..endIndex]
                    });
                    start += 23;
                }
                else
                {
                    break;
                }
            }
            return versions;
        }
    }
}
