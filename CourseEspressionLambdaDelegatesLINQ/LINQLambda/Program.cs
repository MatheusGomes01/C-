using System;
using System.Collections.Generic;
using System.Linq;
using LINQLambda.Entities;


namespace LINQLambda
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>() { 
                new Product(){  Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product(){  Id = 2, Name = "Hamer", Price = 90.0, Category = c1 },
                new Product(){  Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product(){  Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product(){  Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product(){  Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product(){  Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product(){  Id = 8, Name = "Printer", Price = 350.0, Category = c3   },
                new Product(){  Id = 9, Name = "Macbook", Price = 1800.0, Category = c2 },
                new Product(){  Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product(){  Id = 11, Name = "Level", Price = 70.0, Category = c1 },
            };

            // var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            var r1 = from p in products
                     where p.Category.Tier == 1 && p.Price < 900.0
                     select p;

            //var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            var r2 = from p in products
                     where p.Category.Name == "Tools"
                     select p.Name;

            //var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            var r3 = from p in products
                     where p.Name[0] == 'C'
                     select new
                     {
                         p.Name,
                         p.Price,
                         CategoryName = p.Category.Name
                     };

            //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);

            var r4 = from p in products
                     where p.Category.Tier == 1
                     orderby p.Name
                     orderby p.Price
                     select p;

            //var r5 = r4.Skip(2).Take(4);
            var r5 = (from p in r4 select p).Skip(2).Take(4);

            //var r6 = products.First();
            var r6 = (from p in products select p).First();

            //var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            var r7 = (from p in products where p.Price > 3000.0 select p).FirstOrDefault();
            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            var r10 = products.Max(p => p.Price);
            var r11 = products.Min(p => p.Price);
            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            //var r16 = products.GroupBy(p => p.Category);

            var r16 = from p in products group p by p.Category;

            Print("TIER 1 and Price < 900", r1);
            Print("Name of products Tools", r2);
            Print("Name started  with 'C' and anonymous object", r3);
            Print("Tier 1 order by Price and order by Name", r4);
            Print("Tier 1 order by Price and order by Name Skip 2 and Take 4", r5);
            Console.WriteLine("First r6" + r6);
            Console.WriteLine("First r7" + r7);
            Console.WriteLine("Single or default: " + r8);
            Console.WriteLine("Single or default: " + r9);
            Console.WriteLine("Max price: " + r10);
            Console.WriteLine("Min price: " + r11);
            Console.WriteLine("Sum: " + r12);
            Console.WriteLine("Average: " + r13);
            Console.WriteLine("Average default if empty: " + r14);
            Console.WriteLine("Aggreagte sum : " + r15);

            Console.WriteLine();
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }

        }
    }
}
