using System;
using System.Collections.Generic;
using System.Text;

namespace ExFix.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment,
        Processing,
        Shipped,
        Delivered
    }
}
