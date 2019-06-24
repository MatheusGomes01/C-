using Predicate.Entities;
using System;
using System.Collections.Generic;

namespace Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Predicate: representa um metodo que recebe um objeto do tipo T e retorna um valor booleano

            List<Product> list = new List<Product>();
            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //list.RemoveAll(p => p.Price >= 100.00);
            list.RemoveAll(ProductTest);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.00;
        }
    }
}
