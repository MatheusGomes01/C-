using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStreamAndReader
{
    class Program
    {
        static void Main(string[] args)
        {
            /*fileStream é uma classe que disponibiliza uma stream associada a um arquivo, 
             * permitindo operacoes de leitura e escrita e é uma stream de caracteres
             * streamReader é uma stream ou seja uma sequencia de dados, 
             * usado para transmissao de dados em sequencia e é uma stream binária*/

            string path = @"C:\Users\Matheus\Downloads\file.txt";
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                
            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
