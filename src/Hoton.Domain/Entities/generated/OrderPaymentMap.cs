using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class OrderPaymentMap
{
    public Guid OrderId { get; set; }

    public Guid PaymentId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Order Order { get; set; }
}
