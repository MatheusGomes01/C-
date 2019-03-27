using System;
using System.Globalization;

namespace Sobrecargas
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                Sobrecargar é um recurso que uma classe possui de oferever mais de uma operacao com o mesmo nome, 
                porem com diferentes listas de parametros.
            */

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /*
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());
            */
            /*
            sintax alternativa 

                Produto p;
                p = new Produto()
                {
                    Nome = "TV",
                    Preco = 900.00,
                    Quantidade = 30;
                }              
            */

            Produto p;
            p = new Produto(nome, preco);

            Console.WriteLine("Dados do produto: " + p);

        }
    }
}
