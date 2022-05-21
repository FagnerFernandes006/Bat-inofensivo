using System;
using System.Drawing;
using System.IO;
using System.Security;
using System.Windows;

namespace Dadostxt2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string path = @"C:\Temp\virus.bat";
            Dados dados = new Dados();
            if (!File.Exists(@"C:\Temp\"))
            {
                dados.CriaPasta(@"C:\Temp\");
            }
            if (!File.Exists(path))
            {
                dados.Criar(path);
            }
            else
            {
                dados.Abrir(path);
            }
        }
    }
}