using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class Invoice
{
    public Guid Id { get; set; }

    public string InvoiceNumber { get; set; }

    public string InvoiceType { get; set; }

    public decimal Amount { get; set; }

    public decimal Tax { get; set; }

    public string Status { get; set; }

    public string ServiceProvider { get; set; }

    public string CompanyNo { get; set; }

    public string CompanyName { get; set; }

    public string CarrierNo { get; set; }

    public DateTime? IssueDate { get; set; }

    public DateTime? VoidDate { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();

    public virtual ICollection<InvoiceStatusHistory> InvoiceStatusHistories { get; set; } = new List<InvoiceStatusHistory>();

    public virtual ICollection<OrderInvoiceMap> OrderInvoiceMaps { get; set; } = new List<OrderInvoiceMap>();
}
