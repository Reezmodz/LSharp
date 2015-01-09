using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace FioraLoader
{
    class Program
    {
        private static readonly string directory = AppDomain.CurrentDomain.BaseDirectory;

        static void Main(string[] args)
        {
            if(File.Exists(Path.Combine(directory, "FioraCore.exe")))
            {
                File.Delete(Path.Combine(directory, "FioraCore.exe"));
                File.WriteAllBytes(Path.Combine(directory, "FioraCore.exe"), Properties.Resources.FioraCore);
            }
            else
            {
                File.WriteAllBytes(Path.Combine(directory, "FioraCore.exe"), Properties.Resources.FioraCore);
            }
            Process.Start(Path.Combine(directory, "FioraCore.exe"));
            Application.Exit();
        }
    }
}
