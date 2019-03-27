using System;
using System.Globalization;

namespace ProblemaProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p;
            p = new Produto(nome, preco, quantidade);

            Console.WriteLine("Dados do produto: " + p);

            /*
            Contrutor :

            É uma operacao especial da classe, que executa no momento da instanciacao do objeto

            **** usos comuns:
                  * iniciar valores do atributis
                  * PErmitir ou obrigar que o objeto receba dados / dependencias no momento de sua instanciaca (injecao de dependencia)
             
            **** Se um construtor customizado nao for especificado, a classe disponibiliza o contrutor padaro: Produo p = new Produto()


            **** É possivel especificar mais de um construtor na mesma classe (sobrecargar)           
            */
        }
    }
}
