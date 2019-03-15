using System;

namespace ComparaPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas pessoa1, pessoa2;

            pessoa1 = new Pessoas();
            pessoa2 = new Pessoas();

            Console.WriteLine("Digite o nome da primeira pessoa :");
            pessoa1.nome = Console.ReadLine();

            Console.WriteLine("Digite a idade da primeira pessoa :");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa :");
            pessoa2.nome = Console.ReadLine();

            Console.WriteLine("Digite a idade da segunda pessoa :");
            pessoa2.idade = int.Parse(Console.ReadLine());

            if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine("Pessoa mais velha é: " + pessoa1.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha é: " + pessoa2.nome);
            }
        }
    }
}
