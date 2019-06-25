using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             É um conjunto de tecnologis baseadas na integracao de funcionalidades de consulta diretamenta na linguagem C#
             operacaoes chamadas diretamenta a partir das colecoes;
             consultas sao objetos de prmeira classe;
             Suporte do compilador de intelliSense da IDE

            Namespace: System.Linq;

            Possui diversas operacoes de consulta, cujos parametros tipicamente sao expressoes lambda ou expressoes de sintaxe similar a SQL

            para trabalhar com LINQ tem que criar um data source (colecao, array, recurso de E/S, ect.);
            definir a query;
            Executar a query (Foreach ou alguma operacao terminal);

             */

            // specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //Define th equery expression
            var result = numbers.Where(x => x % 2  == 0).Select(x => x * 10);

            // Execute the query 
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
