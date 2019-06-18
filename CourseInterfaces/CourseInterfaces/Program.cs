using System;
using System.Globalization;
using CourseInterfaces.Entities;
using CourseInterfaces.Services;

namespace CourseInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Interface e um tipo que define um tipo de operacoes que uma classe (ou um struct) deve implementar
             Estabele um contrato que a classe(ou struct) deve seguir

            inversão de controle --> padrao de desenvolvimento que conssite em retirar da classe a responsabilidade de 
            instanciar suas dependencias

            injeção de dependencia  --> informa o objeto através do construtor, é uma forma de realizar a inversao de controle:
            um componente externo instancia a dependencia, que é entao injetada no objeto "pai". Pode ser implementada de várias
            maneiras: Contrutor, Objeto de instanciacao (builder/factory), Container/Framework
             */

            Console.WriteLine("Enter rental date");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter PRice per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter PRice per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());
            rentalService.ProcessInvoice(carRental);
            Console.WriteLine("Invoice: ");
            Console.WriteLine(carRental.Envoice);
        }
    }
}
