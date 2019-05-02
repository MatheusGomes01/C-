using System;
using Enum.Entites.Enums;

namespace Enum.Entites
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id + "," +
                   Moment + "," +
                   Status;
        }
    }
}
