using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class OrderInvoice
{
    public Guid Id { get; set; }

    public string RealmId { get; set; }

    public Guid OrderId { get; set; }

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

    public virtual Order Order { get; set; }

    public virtual ICollection<OrderInvoiceItem> OrderInvoiceItems { get; set; } = new List<OrderInvoiceItem>();

    public virtual ICollection<OrderInvoiceStatusHistory> OrderInvoiceStatusHistories { get; set; } = new List<OrderInvoiceStatusHistory>();

    public virtual Realm Realm { get; set; }
}
