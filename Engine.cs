namespace Elysium
{
    public partial class Engine : Form
    {
        Dashboard dash;
        string selected = string.Empty;
        public Engine(Dashboard dashboard, string server)
        {
            InitializeComponent();
            engines.Items.Add("Paper");
            engines.Items.Add("Spigot");
            engines.Items.Add("Craftbukkit");
            engines.Items.Add("Purpur");
            engines.Items.Add("Pufferfish");
            engines.Enabled = true;
            dash = dashboard;
            selected = server;
        }
        private void engines_SelectedIndexChanged(object sender, EventArgs e)
        {
            go.Text = string.Empty;
            go.Enabled = false;
            versions.Enabled = true;
            versions.Items.Clear();
            builds.Enabled = false;
            builds.Items.Clear();
            if (engines.SelectedIndex == 0)
            {
                projectController? project = Paper.AllVersions();
                if (project != null && project.versions != null)
                {
                    project.versions.Reverse();
                    foreach (string? value in project.versions)
                    {
                        versions.Items.Add(value);
                    }
                }
            }
            else if (engines.SelectedIndex == 1)
            {
                Bukkit.LoadVersions("spigot");
                foreach (ServerVersion ver in Bukkit.spigotVersions)
                {
                    if (!string.IsNullOrEmpty(ver.name) && !string.IsNullOrEmpty(ver.url))
                    {
                        versions.Items.Add(ver.name);
                    }
                }
            }
            else if (engines.SelectedIndex == 2)
            {
                Bukkit.LoadVersions("craftbukkit");
                foreach (ServerVersion ver in Bukkit.bukkitVersions)
                {
                    if (!string.IsNullOrEmpty(ver.name) && !string.IsNullOrEmpty(ver.url))
                    {
                        versions.Items.Add(ver.name);
                    }
                }
            }
            else if (engines.SelectedIndex == 3)
            {
                purpurVersions? purpur = Purpur.AllVersions();
                if (purpur != null && purpur.versions != null)
                {
                    purpur.versions.Reverse();
                    foreach (string? value in purpur.versions)
                    {
                        versions.Items.Add(value);
                    }
                }
            }
            else if (engines.SelectedIndex == 4)
            {
                pufferfishVersions? puffer = Pufferfish.AllVersions();
                if (puffer != null && puffer.jobs != null)
                {
                    foreach (pufferfishJob value in puffer.jobs)
                    {
                        if (!string.IsNullOrEmpty(value.name))
                        {
                            versions.Items.Add(value.name);
                        }
                    }
                }
            }
        }
        private void versions_SelectedIndexChanged(object sender, EventArgs e)
        {
            go.Text = string.Empty;
            go.Enabled = false;
            builds.Enabled = true;
            builds.Items.Clear();
            string? picked = versions.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(picked))
            {
                if (engines.SelectedIndex == 0)
                {
                    versionController? version = Paper.Builds(picked);
                    if (version != null && version.builds != null)
                    {
                        version.builds.Reverse();
                        foreach (int value in version.builds)
                        {
                            builds.Items.Add(value);
                        }
                    }
                }
                else if (engines.SelectedIndex == 1)
                {
                    go.Enabled = true;
                    go.Text = engines.SelectedItem + " " + Bukkit.spigotVersions[versions.SelectedIndex].name;
                }
                else if (engines.SelectedIndex == 2)
                {
                    go.Enabled = true;
                    go.Text = engines.SelectedItem + " " + Bukkit.bukkitVersions[versions.SelectedIndex].name;
                }
                if (engines.SelectedIndex == 3)
                {
                    purpurVersion? version = Purpur.Builds(picked);
                    if (version != null && version.builds != null && version.builds.all != null)
                    {
                        version.builds.all.Reverse();
                        foreach (string value in version.builds.all)
                        {
                            builds.Items.Add(value);
                        }
                    }
                }
                if (engines.SelectedIndex == 4)
                {
                    pufferfishBuilds? version = Pufferfish.Builds(picked);
                    if (version != null && version.builds != null && version.builds != null)
                    {
                        foreach (JenkinsBuild value in version.builds)
                        {
                            if (value != null && value.number != null && value.url != null)
                            {
                                builds.Items.Add(value.number);
                            }
                        }
                    }
                }
            }
        }
        private void builds_SelectedIndexChanged(object sender, EventArgs e)
        {
            go.Enabled = true;
            go.Text = engines.SelectedItem + " " + versions.SelectedItem + " (" + builds.SelectedItem + ")";
        }
        private void go_Click(object sender, EventArgs e)
        {
            if (engines.SelectedIndex == 0)
            {
                versionBuildController? versionBuildController = Paper.BuildInfo(versions.SelectedItem, builds.SelectedItem);
                if (versionBuildController != null && versionBuildController.downloads != null && versionBuildController.downloads.application != null && !string.IsNullOrEmpty(versionBuildController.downloads.application.name))
                {
                    string fileName = versionBuildController.downloads.application.name;
                    if (!File.Exists("Servers" + Path.DirectorySeparatorChar + selected + Path.DirectorySeparatorChar + fileName))
                    {
                        byte[] file = Paper.Download(versions.SelectedItem, builds.SelectedItem, fileName);
                        File.WriteAllBytes("Servers" + Path.DirectorySeparatorChar + selected + Path.DirectorySeparatorChar + fileName, file);
                    }
                    Close();
                }
            }
            if (engines.SelectedIndex == 1)
            {
                ServerVersion spigot = Bukkit.spigotVersions[versions.SelectedIndex];
                string fileName = spigot.getFileName();
                if (!File.Exists("Servers" + Path.DirectorySeparatorChar + selected + Path.DirectorySeparatorChar + fileName))
                {
                    byte[] file = spigot.Download();
                    File.WriteAllBytes("Servers" + Path.DirectorySeparatorChar + selected + Path.DirectorySeparatorChar + fileName, file);
                }
                Close();
            }
            if (engines.SelectedIndex == 2)
            {
                ServerVersion bukkit = Bukkit.bukkitVersions[versions.SelectedIndex];
                string fileName = bukkit.getFileName();
                if (!File.Exists("Servers" + Path.DirectorySeparatorChar + selected + Path.DirectorySeparatorChar + fileName))
                {
                    byte[] file = bukkit.Download();
                    File.WriteAllBytes("Servers" + Path.DirectorySeparatorChar + selected + Path.DirectorySeparatorChar + fileName, file);
                }
                Close();
            }
            if (engines.SelectedIndex == 3)
            {
                purpurBuild? build = Purpur.BuildInfo(versions.SelectedItem, builds.SelectedItem);
                if (build != null)
                {
                    string fileName = "purpur-" + versions.SelectedItem + "-" + builds.SelectedItem + ".jar";
                    if (!File.Exists("Servers" + Path.DirectorySeparatorChar + selected + Path.DirectorySeparatorChar + fileName))
                    {
                        byte[] file = build.Download();
                        File.WriteAllBytes("Servers" + Path.DirectorySeparatorChar + selected + Path.DirectorySeparatorChar + fileName, file);
                    }
                    Close();
                }
            }
            if (engines.SelectedIndex == 4)
            {
                pufferfishArtifacts? artifacts = Pufferfish.Artifacts(versions.SelectedItem, builds.SelectedItem);
                if (artifacts != null && artifacts.artifacts != null)
                {
                    string? fileName = "pufferfish-" + versions.SelectedItem + "-" + builds.SelectedItem + ".jar";
                    if (!File.Exists("Servers" + Path.DirectorySeparatorChar + selected + Path.DirectorySeparatorChar + fileName))
                    {
                        byte[] file = artifacts.Download();
                        File.WriteAllBytes("Servers" + Path.DirectorySeparatorChar + selected + Path.DirectorySeparatorChar + fileName, file);
                    }
                    Close();
                }
            }
        }
    }
}