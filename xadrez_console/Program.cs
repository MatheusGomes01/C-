using System;
using tabuleiro;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
