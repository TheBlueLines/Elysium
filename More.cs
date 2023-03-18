namespace Elysium
{
    public class More
    {
        public static bool EulaReader(string file)
        {
            bool resp = false;
            if (File.Exists(file))
            {
                foreach (string line in File.ReadLines(file))
                {
                    if (line.StartsWith("eula="))
                    {
                        string[] tmp = line.Split('=');
                        bool.TryParse(tmp[1], out resp);
                    }
                }
            }
            return resp;
        }
        public static void AcceptEula(string file)
        {
            if (File.Exists(file))
            {
                File.WriteAllText(file, File.ReadAllText(file).Replace("false", "true"));
            }
            else
            {
                File.WriteAllText(file, "eula=true");
            }
        }
    }
}
