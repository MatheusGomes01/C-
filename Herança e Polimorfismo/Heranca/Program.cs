using System;
using Heranca.Entities;
using System.Collections.Generic;
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
            */

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

            /*
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            
            //UPCASTING
            Account acc1 = acc;
            Account acc2 = new BusinessAccount(1003, "bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            //DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
            */

        }
    }
}
