using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;

namespace Elysium
{
	public class Jenkins
	{
		public static HttpClient httpClient = new HttpClient();
        public static JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions()
        {
            WriteIndented = false,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
        public static Jenkins? GetJenkins(string url)
		{
			return JsonSerializer.Deserialize<Jenkins>(httpClient.GetStringAsync(url).Result, jsonSerializerOptions);
		}
        public string? _class { get; set; }
		public string? description { get; set; }
		public string? displayName { get; set; }
		public string? fullDisplayName { get; set; }
		public string? fullName { get; set; }
		public string? name { get; set; }
		public string? url { get; set; }
		public bool? buildable { get; set; }
		public List<JenkinsBuild>? builds { get; set; }
		public string? color { get; set; }
		public JenkinsBuild? firstBuild { get; set; }
		public List<JenkinsHealthReport>? healthReport { get; set; }
		public bool? inQueue { get; set; }
		public bool? keepDependencies { get; set; }
		public JenkinsBuild? lastBuild { get; set; }
		public JenkinsBuild? lastCompletedBuild { get; set; }
		public JenkinsBuild? lastFailedBuild { get; set; }
		public JenkinsBuild? lastStableBuild { get; set; }
		public JenkinsBuild? lastSuccessfulBuild { get; set; }
		public JenkinsBuild? lastUnstableBuild { get; set; }
		public JenkinsBuild? lastUnsuccessfulBuild { get; set; }
		public int? nextBuildNumber { get; set; }
		public List<JenkinsClass>? property { get; set; }
		public bool? concurrentBuild { get; set; }
		public bool? disabled { get; set; }
	}
	public class JenkinsClass
	{
		public string? _class { get; set; }
	}
	public class JenkinsBuild
	{
		public string? _class { get; set; }
		public int? number { get; set; }
		public string? url { get; set; }
        public JenkinsBuildX? Get()
        {
			string json = Jenkins.httpClient.GetStringAsync(url + "api/json").Result;
			JenkinsBuildX? jenkinsBuildX = JsonSerializer.Deserialize<JenkinsBuildX>(json, Jenkins.jsonSerializerOptions);
			if (jenkinsBuildX != null && jenkinsBuildX.artifacts != null)
			{
				foreach (JenkinsArtifact artifact in jenkinsBuildX.artifacts)
				{
					artifact.url = jenkinsBuildX.url;
				}
			}
            return jenkinsBuildX;
        }
    }
	public class JenkinsBuildX
	{
		public string? _class { get; set; }
		public List<JenkinsArtifact>? artifacts { get; set; }
		public bool? building { get; set; }
		public string? description { get; set; }
		public string? displayName { get; set; }
		public int? duration { get; set; }
		public int? estimatedDuration { get; set; }
		public string? fullDisplayName { get; set; }
		public string? id { get; set; }
		public bool? inProgress { get; set; }
		public bool? keepLog { get; set; }
		public int? number { get; set; }
		public int? queueId { get; set; }
		public string? result { get; set; }
		public long? timestamp { get; set; }
		public string? url { get; set; }
	}
	public class JenkinsHealthReport
	{
		public string? description { get; set; }
		public string? iconClassName { get; set; }
		public string? iconUrl { get; set; }
		public int? score { get; set; }
	}
	public class JenkinsArtifact
	{
		internal string? url { get; set; }
        public string? displayPath { get; set; }
		public string? fileName { get; set; }
		public string? relativePath { get; set; }
        public byte[] Download()
        {
            return Pufferfish.client.GetByteArrayAsync(url + "artifact/" + relativePath).Result;
        }
    }
}