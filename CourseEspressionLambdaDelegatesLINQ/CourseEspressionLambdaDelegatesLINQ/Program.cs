﻿using CourseEspressionLambdaDelegatesLINQ.Entities;
using System;
using System.Collections.Generic;

namespace CourseEspressionLambdaDelegatesLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            //Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }

            /*
            static int CompareProducts(Product p1, Product p2)
            {
                return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            }
            */
        }
    }
}
