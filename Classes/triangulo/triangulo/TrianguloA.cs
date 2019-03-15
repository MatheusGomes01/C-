using System;
namespace triangulo
{
    public class TrianguloA
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;

            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return raiz;
        }
    }
}
