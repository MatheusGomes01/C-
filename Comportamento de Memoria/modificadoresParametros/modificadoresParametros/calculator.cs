using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modificadoresParametros
{
class Calculator
    {
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static void Tiple(ref int x) //ref é para tornar o x para a variavel original
        {
            x = x * 3;
        }

        public static void Tiple(int origin, out int result) //out faz o param ser uma referencia para a variavel original e permite que a variavel original nao precise ser iniciada
        {
            result = origin * 3;
        }
    }
}
