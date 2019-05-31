using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectorysFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Servem para criar pastas, listar etc.
             * Directory operaçoes staticas
             * DiretoryInfo operacoes de instancias
             * */

            string path = @"c:\users\matheus\downloads\diretory";

            try
            {
                
                //Folders -->
                IEnumerable<string> folders =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }


                //files -->
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + @"\newFolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred " + e.Message);
            }
        }
    }
}
