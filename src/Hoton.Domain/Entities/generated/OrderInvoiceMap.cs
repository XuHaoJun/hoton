using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class OrderInvoiceMap
{
    public Guid OrderId { get; set; }

    public Guid InvoiceId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Invoice Invoice { get; set; }

    public virtual Order Order { get; set; }
}
