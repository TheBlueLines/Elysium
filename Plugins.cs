namespace Elysium
{
    public partial class Plugins : Form
    {
        private int checkPluginList = -1;
        private int checkBuildList = -1;
        private int checkArtifactList = -1;
        private string selected = string.Empty;
        private Jenkins? jenkins = null;
        private JenkinsBuildX? nzx = null;
        private JenkinsArtifact? artifact = null;
        private List<PluginData> list = new();
        public Plugins(string text)
        {
            selected = text;
            InitializeComponent();
            list.Clear();
            list.AddRange(Program.jenkinsPlugins);
            list.OrderBy(x => x.name);
            foreach (PluginData item in list)
            {
                if (item.name != null)
                {
                    pluginList.Items.Add(item.name);
                }
            }
        }
        private void pluginList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox? temp = sender as ListBox;
            if (temp != null)
            {
                if (checkPluginList != temp.SelectedIndex)
                {
                    checkPluginList = temp.SelectedIndex;
                    checkBuildList = -1;
                    checkArtifactList = -1;
                    buildList.Items.Clear();
                    buildList.Enabled = false;
                    artifactList.Items.Clear();
                    artifactList.Enabled = false;
                    artifact = null;
                    go.Text = string.Empty;
                    go.Enabled = false;
                    if (temp.SelectedIndex >= 0)
                    {
                        string? url = list[temp.SelectedIndex].url;
                        if (!string.IsNullOrEmpty(url))
                        {
                            jenkins = Jenkins.GetJenkins(url + "/api/json");
                            if (jenkins != null && jenkins.builds != null)
                            {
                                foreach (JenkinsBuild value in jenkins.builds)
                                {
                                    if (value.number != null)
                                    {
                                        buildList.Items.Add(value.number);
                                        buildList.Enabled = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void buildList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox? temp = sender as ListBox;
            if (temp != null)
            {
                if (checkBuildList != temp.SelectedIndex)
                {
                    checkBuildList = temp.SelectedIndex;
                    checkArtifactList = -1;
                    artifactList.Items.Clear();
                    artifactList.Enabled = false;
                    artifact = null;
                    go.Text = string.Empty;
                    go.Enabled = false;
                    if (temp.SelectedIndex >= 0 && jenkins != null && jenkins.builds != null)
                    {
                        nzx = jenkins.builds[temp.SelectedIndex].Get();
                        if (nzx != null && nzx.artifacts != null)
                        {
                            foreach (JenkinsArtifact artifact in nzx.artifacts)
                            {
                                if (artifact.fileName != null)
                                {
                                    artifactList.Items.Add(artifact.fileName);
                                    artifactList.Enabled = true;
                                }
                            }
                        }
                    }
                }
            }
        }
        private void artifactList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox? temp = sender as ListBox;
            if (temp != null)
            {
                if (checkArtifactList != temp.SelectedIndex)
                {
                    artifact = null;
                    go.Text = string.Empty;
                    go.Enabled = false;
                    checkArtifactList = temp.SelectedIndex;
                    if (temp.SelectedIndex >= 0 && nzx != null && nzx.artifacts != null)
                    {
                        artifact = nzx.artifacts[temp.SelectedIndex];
                        go.Text = "Download";
                        go.Enabled = true;
                    }
                }
            }
        }
        private void go_Click(object sender, EventArgs e)
        {
            if (artifact != null)
            {
                Directory.CreateDirectory("Servers\\" + selected + "\\Plugins");
                go.Text = "Downloading";
                File.WriteAllBytes("Servers\\" + selected + "\\Plugins\\" + artifact.fileName, artifact.Download());
                go.Text = "Downloaded";
            }
        }
    }
}