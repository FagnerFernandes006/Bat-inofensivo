using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dadostxt2
{
    public class Dados
    {
        public void Criar(string path)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = path;
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine("calc");
            sw.WriteLine("explorer");
            sw.WriteLine("notepad");
            sw.WriteLine("charmap");
            sw.WriteLine("mspaint");
            sw.WriteLine("cmd");
            sw.WriteLine("taskmgr");
            sw.Close();
            System.Diagnostics.Process.Start(startInfo);
        }
        public void Abrir(string path)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = path;
            System.Diagnostics.Process.Start(startInfo);
        }
        public void CriaPasta(string patch)
        {
            Directory.CreateDirectory(@"C:\Temp\");
        }
    }
}
