using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<double> x = null;
            //ou double? x = null

            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault()); // traz o valor defaul da variavel ou o setado
            Console.WriteLine(y.GetValueOrDefault()); // traz o valor defaul da variavel ou o setado

            Console.WriteLine(x.HasValue);// indica se tem valor ou nao (true/false)
            Console.WriteLine(x.HasValue);// indica se tem valor ou nao (true/false)

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X é nulo");
            }


            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y é nulo");
            }

            Console.WriteLine(y = x ?? 15.00);
        }
    }
}
