using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Computer_name_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ConfigDirectory = $"{Directory.GetCurrentDirectory()}\\ConfigurationFiles";
            if (!Directory.Exists(ConfigDirectory))
            {
                Directory.CreateDirectory(ConfigDirectory);
            }

            string PathToConfigSave = ConfigDirectory + '\\' + Dns.GetHostName() + ".dat";

            Console.WriteLine(PathToConfigSave);
            Console.WriteLine("MachinName (env): {0}", Environment.MachineName);
            Console.WriteLine("MachinName (sysInfo): {0}", SystemInformation.ComputerName);
            Console.WriteLine("MachinName (DNS): {0}", Dns.GetHostName());
            Console.WriteLine("MachinName (env var): {0}", Environment.GetEnvironmentVariable("COMPUTER NAME", EnvironmentVariableTarget.User));
            Console.ReadLine();
        }
    }
}
