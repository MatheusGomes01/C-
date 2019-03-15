using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("Quantas vezes vc quer imprimir esta folha ?");
            int impressao = int.Parse(Console.ReadLine());

            for (int i = 1; i <= impressao; i++)
            {
                Console.WriteLine("folha " + i);

            }*/

            Console.WriteLine("Quantos numeros vc vai digitar ?");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Valor #{0} :", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine("Soma = " + soma);
        }
    }
}
