using System;
namespace membrosEstaticos
{
    public class Calculadora
    {
        public static double PI = 3.14;

        public static double Circuferencia(double raio)
        {
            raio = 2.0 * PI * raio;

            return raio;
        }

        public static double Volume(double raio)
        {
            raio = Math.Pow(raio, 3); //ou raio * raio * raio
            return 4.0 / 3.0 * PI * raio;
        }
    }
}
