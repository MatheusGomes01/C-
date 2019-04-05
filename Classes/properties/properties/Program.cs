using System;
using System.Globalization;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                * Properties são definicoes de metodos encapsulados, porem expondo sintaxe similar a de atributos e nao 
                * de metodos
            */

            Produto p;
            p = new Produto("TV", 500.00, 10 );

            p.Nome = "T";

            Console.WriteLine(p.Nome);
        }
    }
}
