using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Lista é uma estrutura de dados homogenea (Dados do mesmo tipo, ordenada, inicia vazia e vai sendo preenchida, cada elemento ocupa um nó da lista)
             * Classe : List, Namespane: System.Collections.Generic
             * Vantagens: Tamano variavel e Facilidade para realizar inserções e declaracoes
             * Desvantagens: Acesso sequencial aos elementos*
             */

            /*
            List<string> list = new List<string>();
            List<string> list2 = new List<string> { "Maria", "Roberto" };
            */

            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count:" + list.Count());

            string s1 = list.Find(Test); //or expression lambda ' string s1 = list.Find(x => x[0] == 'A');' find Procura a primeira posicao que comeca com tal caracter
            Console.WriteLine("First 'A'" + s1);

           string s2 = list.FindLast(x => x[0] == 'A'); // FindLast procura a ultima posicao de quem comeca com a letra tal
            Console.WriteLine("Last 'A'" + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A'); //procura a primeira posicao com a letra tal
            Console.WriteLine("First position 'A'" + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A'); // procura a ultima posicao com a letra tal
            Console.WriteLine("Last position 'A'" + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);//procura apena de acordo com a condicao
            Console.WriteLine("------------------------");
            foreach (string obj  in list2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------");
            list.RemoveRange(2,2);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------");
            list.RemoveAt(1);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------");
            list.Remove("Alex");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            
            Console.WriteLine("------------------------");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }   

        static bool Test(string s)
        {
            return s[0] == 'A';
        }
    }
}
