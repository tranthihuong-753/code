using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFiletxt
{
    internal class Program
    {
        // File ghi 
        static void writetxt(string nameFile)
        {
            if(File.Exists(nameFile))
            {
                FileStream st = new FileStream(nameFile, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(st);
                sw.WriteLine("\nthem nua 1");
                sw.Close();
            }
            else
            {
                FileStream st = new FileStream(nameFile, FileMode.Create, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(st);
                sw.WriteLine("\nPApa");
                sw.Close();
            }
        }
        // File doc all 
        static void readtxtAll(string nameFile)
        {
            if(File.Exists(nameFile))
            {
                FileStream fs = new FileStream(nameFile, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
            }
            else
            {
                Console.WriteLine("File {nameFile} no exists.");            }
        }
        static void Main(string[] args)
        {
            writetxt("filetxt180724.txt");
            //Console.WriteLine("Hanh phuc vien man.");
            readtxtAll("filetxt180724.txt");
            //Console.WriteLine("Cut moe di.");
        }
    }
}
