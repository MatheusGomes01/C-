using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Matheus\Downloads\file.txt";
            string targetPath = @"C:\Users\Matheus\Downloads\file1.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred"); ;
                Console.WriteLine(e.Message);
            }
        }
    }
}
