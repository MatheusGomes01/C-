using CourseFunc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            //representa um metodo que recebe zero ou mais argumentos, e retorna um valor, ele tem 16 sobrecargas
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD", 80.90));
            Func<Product, string> func = NameUpper;

            //List<string> result = list.Select(NameUpper).ToList();
            //List<string> result = list.Select(func).ToList();

            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
