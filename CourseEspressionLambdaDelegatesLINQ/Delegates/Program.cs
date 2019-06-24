using System;
using Delegates.Services;

namespace Delegates
{
    class Program
    {

        delegate double BinaryNumericOperation(double n1, double n2);
        static void Main(string[] args)
        {
            /*
               É uma referencia (com type safety) para um ou mais metodos
               uso comum em comunicacao entre objetos de forma flexivel e extensivel(eventos/callbacks)
               parametrizacao de operacao por metodos(programacao funcional)

               Action, Func, Predicate
             */

            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;
           
            double result = CalculationService.Square(a);
            Console.WriteLine(result);
            Console.WriteLine(op(a, b));

        }
    }
}
