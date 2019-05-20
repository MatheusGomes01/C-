using System;
using Heranca.Entities;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                É um tipo de associação que permite que uma classe herde dadoes e comportamentos de outra
                Vantages : Reuso, Polimorfismo
                Sintaxe: ":" (os dois pontos é a referencia da herança e lemos como estende)
                base (referencia da superclasse)
                SuperClasse é a classe generica
                SubClasse é a classe que deriva da SuperClasse
                UpCasting é o casting da subClasse para a superclasse, uso comum no polimorfismo
                DownCastrin é o contratio do Up, uso comum em methosdos que recebem metodos genericos

                Polimorfismo, é o recurso que permite que variaveis de um mesmo tipo mais generico possam apontar para objetos de tipos especificos
                diferentes, tendo assim comportamentos diferentes conforme cada tipo especifico

                abstract é quando vc nao pode instanciar a classe no programa principal e uma classe abstrata é representata pelo italico
            */

            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Ana", 500.0, 500.0));

            var sum = 0.0;

            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2",CultureInfo.InstalledUICulture));

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }

            foreach (Account acc in list)
            {
                Console.WriteLine("updated balance for account" + acc.Number + ": " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }


        }
    }
}
