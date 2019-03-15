using System;

namespace EsctruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int x = 10;

            Console.WriteLine("Bom dia!");

            if (x < 5) {
                Console.WriteLine("Boa tarde!");
            }

            Console.WriteLine("Boa noite!");*/

            /*Console.WriteLine("Entre com um numero inteiro :");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Par !");
            }
            else
            {
                Console.WriteLine("Impar !");
            }*/

            Console.WriteLine("Digite um horario");
            int hora = int.Parse(Console.ReadLine());

            if (hora >= 0 && hora < 12)
            {
                Console.WriteLine("Bom dia !");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde !");
            }
            else if (hora < 24)
            {
                Console.WriteLine("Boa noite !");
            }
            else
            {
                Console.WriteLine("O horario digitado e incompativel");

            }
        }
    }
}
