using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class OrderInvoiceItem
{
    public Guid Id { get; set; }

    public Guid OrderInvoiceId { get; set; }

    public string ProductName { get; set; }

    public string TaxType { get; set; }

    public string Remark { get; set; }

    public string UnitWord { get; set; }

    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual OrderInvoice OrderInvoice { get; set; }
}
