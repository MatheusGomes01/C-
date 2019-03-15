using System;

namespace EscopoInicializacao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double preco = double.Parse(Console.ReadLine());

            if (preco > 100.0)
            {
                double desconto = preco * 0.1;
            }*/

            Console.WriteLine("Digite trës números");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado); 
        }

        static int Maior(int a, int b, int c)
        {
            int m; 
            if ( a > b && a > c)
            {
                m = a;

            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }

            return m;
        }
    }
}
