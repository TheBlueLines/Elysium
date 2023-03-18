namespace Elysium
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            LoadServerList();
            New.Enabled = true;
            Remote.Enabled = false;
            try
            {
                projectController? project = Paper.AllVersions();
                if (project != null && project.versions != null)
                {
                    info.Text = "Latest paper: " + project.versions.Last();
                }
                Program.jenkinsPlugins.Clear();
                Elysium? elysium = Elysium.Get();
                if (elysium != null && elysium.jenkinsPlugins != null)
                {
                    Program.jenkinsPlugins = elysium.jenkinsPlugins;
                }
            }
            catch
            {
                info.Text = "Offline";
            }
        }
        private void LoadServerList()
        {
            Servers.Items.Clear();
            Directory.CreateDirectory("Servers");
            foreach (string value in Directory.GetDirectories("Servers"))
            {
                string? tmp = Path.GetFileName(value);
                if (!string.IsNullOrEmpty(tmp))
                {
                    Servers.Items.Add(tmp);
                }
            }
        }
        private void New_Click(object sender, EventArgs e)
        {
            NewServer newServer = new();
            newServer.ShowDialog();
            AddServer(newServer.selected);
        }
        public void AddServer(string server)
        {
            if (!string.IsNullOrEmpty(server))
            {
                if (!Directory.Exists("Servers" + Path.DirectorySeparatorChar + server))
                {
                    Servers.Items.Add(server);
                    Directory.CreateDirectory("Servers" + Path.DirectorySeparatorChar + server);
                }
            }
        }
        private void Servers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Servers.SelectedItem != null)
            {
                bool mode = Directory.Exists("Servers" + Path.DirectorySeparatorChar + Servers.SelectedItem.ToString());
                Remove.Enabled = mode;
                Dashboard.Enabled = mode;
                Rename.Enabled = mode;
            }
        }
        private void Remove_Click(object sender, EventArgs e)
        {
            Directory.Delete("Servers" + Path.DirectorySeparatorChar + Servers.SelectedItem.ToString(), true);
            Servers.Items.Remove(Servers.SelectedItem);
            Remove.Enabled = false;
            Dashboard.Enabled = false;
            Rename.Enabled = false;
        }
        private void Remote_Click(object sender, EventArgs e)
        {
            //Process.Start(new ProcessStartInfo("https://discord.gg/UjDNDqDbRE") { UseShellExecute = true });
        }
        private void Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dash = new(Servers.SelectedItem.ToString());
            Program.dashboards.Add(dash);
            dash.Show();
        }
        private void Rename_Click(object sender, EventArgs e)
        {
            if (Servers.SelectedItem != null)
            {
                NewServer newServer = new();
                newServer.ShowDialog();
                if (Directory.Exists("Servers" + Path.DirectorySeparatorChar + Servers.SelectedItem.ToString()))
                {
                    if (!Directory.Exists("Servers" + Path.DirectorySeparatorChar + newServer.selected))
                    {
                        Directory.Move("Servers" + Path.DirectorySeparatorChar + Servers.SelectedItem.ToString(), "Servers" + Path.DirectorySeparatorChar + newServer.selected);
                        LoadServerList();
                    }
                }
            }
        }
        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<Task> tasks = new();
            foreach (Dashboard value in Program.dashboards)
            {
                Task tsk = new Task(() => CloseDashboard(value));
                tsk.RunSynchronously();
                tasks.Add(tsk);
            }
            Task.WhenAll(tasks);
        }
        private void CloseDashboard(Dashboard dash)
        {
            dash.CloseServer();
            dash.Close();
        }
    }
}