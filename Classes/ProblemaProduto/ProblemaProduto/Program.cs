using System;
using System.Globalization;

namespace ProblemaProduto
{
    class Program
    {
        static void Main(string[] args)
        {
           
           Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");

            Console.Write("Nome : ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.Write("Dados do produto: " + p);
                      

            /*
            var valorFormatado = string.Format("R$ {0:#,###.##}", 1234.32);
            Console.WriteLine(valorFormatado);
            */          
        }
    }
}
