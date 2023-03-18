using System.Text.Json;

namespace Elysium
{
    public class pufferfishVersions
    {
        public List<pufferfishJob>? jobs { get; set; }
    }
    public class pufferfishBuilds
    {
        public List<JenkinsBuild>? builds { get; set; }
    }
    public class pufferfishJob
    {
        public string? _class { get; set; }
        public string? name { get; set; }
        public string? url { get; set; }
        public string? color { get; set; }
    }
    public class pufferfishArtifacts
    {
        public List<JenkinsArtifact>? artifacts { get; set; }
        public string? url { get; set; }
        public byte[] Download()
        {
            if (artifacts != null)
            {
                return Pufferfish.client.GetByteArrayAsync(url + "artifact/" + artifacts.First().relativePath).Result;
            }
            return new byte[0];
        }
    }
    internal class Pufferfish
    {
        public static HttpClient client = new();
        public static pufferfishVersions? AllVersions()
        {
            string json = client.GetStringAsync("https://ci.pufferfish.host/api/json").Result;
            pufferfishVersions? resp = JsonSerializer.Deserialize<pufferfishVersions>(json);
            List<pufferfishJob> jobs = new();
            if (resp != null && resp.jobs != null)
            {
                foreach (pufferfishJob value in resp.jobs)
                {
                    if (value.name != null && value.name.StartsWith("Pufferfish-1."))
                    {
                        value.name = value.name.Split('-')[1];
                        jobs.Add(value);
                    }
                }
                jobs.Reverse();
                resp.jobs = jobs;
            }
            return resp;
        }
        public static pufferfishBuilds? Builds(object version)
        {
            string json = client.GetStringAsync("https://ci.pufferfish.host/job/Pufferfish-" + version+"/api/json").Result;
            return JsonSerializer.Deserialize<pufferfishBuilds>(json);
        }
        public static pufferfishArtifacts? Artifacts(object version, object build)
        {
            string json = client.GetStringAsync("https://ci.pufferfish.host/job/Pufferfish-" + version + "/" + build + "/api/json").Result;
            return JsonSerializer.Deserialize<pufferfishArtifacts>(json);
        }
    }
}
