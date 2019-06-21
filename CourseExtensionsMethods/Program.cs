using System;
using CourseExtensionsMethods.Extensions;

namespace CourseExtensionsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             sao metodos que estendem a funcionalidade de um tipo, sem precisar alterar o codigo fonte deste tipo,
             nem herdar desse tipo

            Extension Method é um alcasse estatica, com método estatico, onde o primeiro parametro deste metodo
            é o this, seguindo da declaracao de um parametro do tipo que deseja estender.
             */

            /*
                DateTime dt = new DateTime(2019, 6, 20, 8, 10, 45);
                Console.WriteLine(dt.ElapsedTime());
            */

            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
