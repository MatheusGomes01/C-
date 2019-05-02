using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum.Entites.Enums
{
    enum OrderStatus : int
    {
        PendingPayment, //ou PendingPayment = 0, C# faz uma contagem default
        Processing,
        Shipped,
        Delivered

    }
}
