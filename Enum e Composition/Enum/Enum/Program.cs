using Enum.Entites;
using Enum.Entites.Enums;
using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order;
            order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

        }
    }
}
