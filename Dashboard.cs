using System.Diagnostics;

namespace Elysium
{
    public partial class Dashboard : Form
    {
        private string engineFile = string.Empty;
        private Process? server = null;
        public Dashboard(string? selected)
        {
            InitializeComponent();
            Text = selected;
            Title.Text = selected;
            LockServer();
            CheckForEngine();
            Software.Enabled = true;
        }
        private void Software_Click(object sender, EventArgs e)
        {
            new Engine(this, Text).ShowDialog();
            CheckForEngine();
        }
        public void CheckForEngine()
        {
            string[] files = Directory.GetFiles("Servers" + Path.DirectorySeparatorChar + Text);
            foreach (string file in files)
            {
                string tmp = Path.GetFileName(file);
                if (tmp.StartsWith("paper-") && tmp.EndsWith(".jar"))
                {
                    string[] temp = tmp.Split('-');
                    engine.Text = "Paper " + temp[1] + " (" + temp[2][..^4] + ")";
                    engineFile = tmp;
                    LockServer(true);
                }
                else if (tmp.StartsWith("spigot-") && tmp.EndsWith(".jar"))
                {
                    string[] temp = tmp.Split('-');
                    engine.Text = "Spigot " + temp[1][..^4];
                    engineFile = tmp;
                    LockServer(true);
                }
                else if (tmp.StartsWith("craftbukkit-") && tmp.EndsWith(".jar"))
                {
                    string[] temp = tmp.Split('-');
                    engine.Text = "Craftbukkit " + temp[1][..^4];
                    engineFile = tmp;
                    LockServer(true);
                }
                else if (tmp.StartsWith("purpur-") && tmp.EndsWith(".jar"))
                {
                    string[] temp = tmp.Split('-');
                    engine.Text = "Purpur " + temp[1] + " (" + temp[2][..^4] + ")";
                    engineFile = tmp;
                    LockServer(true);
                }
                else if (tmp.StartsWith("pufferfish-") && tmp.EndsWith(".jar"))
                {
                    string[] temp = tmp.Split('-');
                    engine.Text = "Pufferfish " + temp[1] + " (" + temp[2][..^4] + ")";
                    engineFile = tmp;
                    LockServer(true);
                }
            }
        }
        private void LockServer(bool mode = false)
        {
            Plugins.Enabled = mode;
            Skript.Enabled = mode;
            Properties.Enabled = mode;
            Files.Enabled = mode;
            Start.Enabled = mode;
        }
        private void Files_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", "Servers" + Path.DirectorySeparatorChar + Text);
        }
        private void Start_Click(object sender, EventArgs e)
        {
            if (Start.Text == "Start")
            {
                log.Clear();
                Start.Text = "Stop";
                bool resp = More.EulaReader("Servers" + Path.DirectorySeparatorChar + Text + Path.DirectorySeparatorChar + "eula.txt");
                if (!resp)
                {
                    Process.Start(new ProcessStartInfo("https://aka.ms/MinecraftEULA") { UseShellExecute = true });
                    DialogResult result = MessageBox.Show("By pressing YES below you are indicating your agreement to our EULA (https://aka.ms/MinecraftEULA)", "Minecraft Server EULA", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        More.AcceptEula("Servers" + Path.DirectorySeparatorChar + Text + Path.DirectorySeparatorChar + "eula.txt");
                    }
                }
                command.Enabled = true;
                server = new();
                server.EnableRaisingEvents = true;
                server.OutputDataReceived += new DataReceivedEventHandler(process_OutputDataReceived);
                server.ErrorDataReceived += new DataReceivedEventHandler(process_ErrorDataReceived);
                server.Exited += new EventHandler(process_Exited);
                server.StartInfo.FileName = "java";
                server.StartInfo.WorkingDirectory = "Servers" + Path.DirectorySeparatorChar + Text;
                server.StartInfo.Arguments = "-Xmx2G -jar " + engineFile + " nogui";
                server.StartInfo.UseShellExecute = false;
                server.StartInfo.RedirectStandardOutput = true;
                server.StartInfo.RedirectStandardError = true;
                server.StartInfo.RedirectStandardInput = true;
                server.StartInfo.CreateNoWindow = true;
                server.Start();
                server.BeginErrorReadLine();
                server.BeginOutputReadLine();
            }
            else if (Start.Text == "Stop")
            {
                if (server != null)
                {
                    Start.Enabled = false;
                    server.StandardInput.WriteLine("stop");
                }
            }
        }
        void process_Exited(object? sender, EventArgs e)
        {
            Start.Enabled = true;
            Start.Text = "Start";
            command.Enabled = false;
        }
        void process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            WriteToWall(e.Data);
        }
        void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            WriteToWall(e.Data);
        }
        private void WriteToWall(string? text)
        {
            log.AppendText(text + "\n");
            log.ScrollToCaret();
        }
        private void send_Click(object sender, EventArgs e)
        {
            if (server != null)
            {
                server.StandardInput.WriteLine(command.Text);
                command.Clear();
            }
        }
        private void command_TextChanged(object sender, EventArgs e)
        {
            send.Enabled = !string.IsNullOrEmpty(command.Text);
        }
        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseServer();
        }
        public void CloseServer()
        {
            if (server != null)
            {
                Start.Enabled = false;
                server.StandardInput.WriteLine("stop");
                server.WaitForExit();
            }
        }
        private void command_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (server != null && e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                server.StandardInput.WriteLine(command.Text);
                command.Clear();
            }
        }
        private void Skript_Click(object sender, EventArgs e)
        {
            string skript = "https://github.com/SkriptLang/Skript/releases/latest/download/Skript.jar";
            string path = "Servers" + Path.DirectorySeparatorChar + Text + Path.DirectorySeparatorChar + "plugins" + Path.DirectorySeparatorChar + "Skript.jar";
            if (!File.Exists(path))
            {
                DialogResult result = MessageBox.Show("Do you want to download it?", "Skript plugin is not found!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    HttpClient client = new();
                    File.WriteAllBytes(path, client.GetByteArrayAsync(skript).Result);
                }
            }
            if (File.Exists(path))
            {
                path = "Servers" + Path.DirectorySeparatorChar + Text + Path.DirectorySeparatorChar + "plugins" + Path.DirectorySeparatorChar + "Skript" + Path.DirectorySeparatorChar + "scripts";
                Directory.CreateDirectory(path);
                Process.Start("explorer", path);
            }
        }
        private void Plugins_Click(object sender, EventArgs e)
        {
            //string path = "Servers" + Path.DirectorySeparatorChar + Text + Path.DirectorySeparatorChar + "plugins";
            //Directory.CreateDirectory(path);
            //Process.Start("explorer", path);
            Plugins plugins = new(Text);
            plugins.ShowDialog();
        }
        private void Properties_Click(object sender, EventArgs e)
        {
            string path = "Servers" + Path.DirectorySeparatorChar + Text + Path.DirectorySeparatorChar + "server.properties";
            if (File.Exists(path))
            {
                Process.Start("explorer", path);
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            CloseServer();
            Close();
        }
    }
}