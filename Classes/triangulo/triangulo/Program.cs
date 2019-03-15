using System;
using System.Globalization;

namespace triangulo
{
    class Program
    {
        static void Main(string[] args)
        { 
            /*double xA, xB, xC, yA, yB, yC;
            Console.WriteLine("Entre com as medidas do triangulo x :");

            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo y :");

            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("area triangulo x = " + areaX);
            Console.WriteLine("area triangulo y = " + areaY);*/

            TrianguloA x, y;
            x = new TrianguloA();
            y = new TrianguloA();

            Console.WriteLine("Entre com as medidas do triangulo x :");

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo y :");

            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /*
            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));
            */

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("area triangulo x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("area triangulo y = " + areaY.ToString("F4", CultureInfo.InvariantCulture)); 

        }
    }
}
