using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace StreamWriters
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Stream capaz de escrever caracteres a partir de uma stream binária
             */

            string sourcePath = @"c:\users\matheus\downloads\file.txt";
            string targetPath = @"c:\users\matheus\downloads\file1.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An erro occurred " + e.Message);
                
            }
        }
    }
}
