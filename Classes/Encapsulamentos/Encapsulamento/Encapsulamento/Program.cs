using System;
using System.Globalization;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                * Encapsulamento e um principio que consiste em esconder detalhes um componente, expondo apenas
                * operacoes seguras e que o mantenham em um estado consister (a propria claase deve fazer isso)
                * Todo atributo e definido como private e implementa-se methosdos get(obeter) e set(definir) como regra de negocio
            */

            Produto p;
            p = new Produto("TV", 500.00, 10);
            p.SetNome("T");

            Console.WriteLine(p.GetNome());
        }
    }
}
