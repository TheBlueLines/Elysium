using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Elysium_MC_Server_Creator
{
    public partial class Form1 : Form
    {
        public string work = @"C:\Elysium";
        public string run;
        public Form1()
        {
            InitializeComponent();
            path.Text = work+@"\Servers\elysium";
        }
        private void name_TextChanged(object sender, EventArgs e)
        {
            if (name.Text == "") {
                path.Text = work + @"\Servers\elysium";
            }
            else
            {
                path.Text = work + @"\Servers\" + name.Text;
            }
        }
        private void Start_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(work);
            Directory.CreateDirectory(work + @"\Servers");
            Directory.CreateDirectory(path.Text);
            try
            {
                run = File.ReadAllText(path.Text + @"\run.bat");
                Console.WriteLine("Server found!");
            }
            catch
            {
                Console.WriteLine("Server not found!");
                Console.WriteLine("Downloading server...");
                WebClient webClient = new WebClient();
                webClient.DownloadFile("http://darknight.hu:8080/server.jar", path.Text+@"\server.jar");
                Console.WriteLine("Downloaded!");
                File.WriteAllText(path.Text + @"\run.bat", "@echo off\ncd "+path.Text+"\njava -Xmx2G -jar server.jar\nPAUSE");
                File.WriteAllText(path.Text + @"\eula.txt","eula=false");
            }
        }
        private void go_Click(object sender, EventArgs e)
        {
            if (File.ReadAllText(path.Text + @"\eula.txt") != "eula=true")
            {
                ProcessStartInfo eula = new ProcessStartInfo("https://account.mojang.com/documents/minecraft_eula");
                Process.Start(eula);
                DialogResult result = MessageBox.Show("By pressing " + DialogResult.Yes + " below you are indicating your agreement to our EULA (https://account.mojang.com/documents/minecraft_eula)", "You need to agree to the EULA in order to run the server", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    File.WriteAllText(path.Text + @"\eula.txt", "eula=true");
                }
                else if (result == DialogResult.No)
                {
                    File.WriteAllText(path.Text + @"\eula.txt", "eula=false");
                }
            }
            ProcessStartInfo server = new ProcessStartInfo
            {
                FileName = path.Text + @"\run.bat"
            };
            Console.WriteLine(path.Text + @"\run.bat");
            Process.Start(server);
        }

        private void plugins_Click(object sender, EventArgs e)
        {
            ProcessStartInfo x = new ProcessStartInfo
            {
                FileName = @"C:\Windows\explorer.exe",
                Arguments = path.Text + @"\plugins"
            };
            Process.Start(x);
        }

        private void properties_Click(object sender, EventArgs e)
        {
            ProcessStartInfo properties = new ProcessStartInfo
            {
                FileName = @"C:\Windows\notepad.exe",
                Arguments = path.Text + @"\server.properties"
            };
            Process.Start(properties);
        }

        private void RunArgument_Click(object sender, EventArgs e)
        {
            ProcessStartInfo x = new ProcessStartInfo
            {
                FileName = "notepad.exe",
                Arguments = path.Text + @"\run.bat"
            };
            Process.Start(x);
        }
        private void Scripts_Click(object sender, EventArgs e)
        {
            try
            {
                File.ReadAllText(path.Text + @"\plugins\Skript.jar");
                ProcessStartInfo x = new ProcessStartInfo
                {
                    FileName = @"C:\Windows\explorer.exe",
                    Arguments = path.Text + @"\plugins\Skript\scripts"
                };
                Process.Start(x);
            }
            catch
            {
                DialogResult result = MessageBox.Show("Do you want to download it?", "Skript plugin is not found!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile("https://github.com/SkriptLang/Skript/releases/download/2.5.2/Skript.jar", path.Text + @"\plugins\Skript.jar");
                }
            }
        }
    }
}
