using System;
using System.Globalization;

namespace AutoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                * AutoProperties é uma forma simplificada de se declarar propriedades que nao necessitam 
                * logicas particularespara operacoes get e set               
                * 
                * Ordem sugerida na OO
                * 
                * Atributos Privativos;
                * Propriedades autoimplementadas;
                * Contrutores;
                * Propriedades Customizadas;
                * outros metodos de classe;
            */


            Produto p;
            p = new Produto("TV", 500.00, 10);

            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
    }
}
