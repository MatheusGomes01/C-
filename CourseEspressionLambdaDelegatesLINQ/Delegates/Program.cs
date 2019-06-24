using System;
using Delegates.Services;

namespace Delegates
{
    class Program
    {

        //delegate double BinaryNumericOperation(double n1, double n2);
        delegate void BinaryNumericOperation(double n1, double n2);
        static void Main(string[] args)
        {
            /*
               É uma referencia (com type safety) para um ou mais metodos
               uso comum em comunicacao entre objetos de forma flexivel e extensivel(eventos/callbacks)
               parametrizacao de operacao por metodos(programacao funcional)

               Action, Func, Predicate

            Multicast delegates: guardam a referencia para mais de um metodo
            para adicionar uma referencia, pode-se usar o +=
            a chamada Invoke(ou sintaxe reduzida) executa todos os metodos na ordem em que foram adicionados
            Seu uso faz sentido para metodos void
             */

            double a = 10;
            double b = 12;

            // BinaryNumericOperation op = CalculationService.Sum;
            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMAx;

            double result = CalculationService.Square(a);
            Console.WriteLine(result);
            op.Invoke(a, b);
          //  Console.WriteLine(op(a, b));

        }
    }
}
