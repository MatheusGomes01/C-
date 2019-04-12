using System;

namespace VectFixed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos Quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Aluguel[] vect;
            vect = new Aluguel[n];
            string alugados = "";
            string nAlugados = "";

            for (int i = 0; i < n; i++)
            { 
                string name = Console.ReadLine();
                string email = Console.ReadLine();
                int quarto = int.Parse(Console.ReadLine());

                vect[i] = new Aluguel { Nome = name, Email = email, Quarto = quarto };

            }

            for (int i = 0; i < n; i++)
            {
               alugados += " Pessoa : " + vect[i].Nome +
                           " Email : " + vect[i].Email +
                           " Quarto : " + vect[i].Quarto;
            }

            Console.WriteLine("vect: "+ alugados);
        }
    }
}
