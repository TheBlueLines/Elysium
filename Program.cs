namespace Elysium
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Start());
        }
        public static List<Dashboard> dashboards = new();
        public static List<PluginData> jenkinsPlugins = new();
        public static string ElysiumAPI = "http://nzx.hu/elysium/api.json";
    }
}