using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace BlockUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\users\matheus\downloads\file.txt";

            try
            {

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            }
            catch (IOException e)
            {

                Console.WriteLine("An error occurred " + e.Message);
            }

        }
    }
}
