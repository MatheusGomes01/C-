using System;
using System.Globalization;

namespace membrosEstaticos
{
    class Program
    {

        static void Main(string[] args)
        {
            //Calculadora calculator;
            //calculator = new Calculadora();

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Calculadora.Circuferencia(raio);
            double vol = Calculadora.Volume(raio);

            Console.WriteLine("Circ: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PI:" + Calculadora.PI.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
