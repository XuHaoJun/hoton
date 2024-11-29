using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class Order
{
    public Guid Id { get; set; }

    public string RealmId { get; set; }

    public string TransactionNo { get; set; }

    public string CustomerName { get; set; }

    public decimal TotalAmount { get; set; }

    public decimal ShipmentFee { get; set; }

    public string Status { get; set; }

    public string UserId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<OrderInvoice> OrderInvoices { get; set; } = new List<OrderInvoice>();

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<OrderPayment> OrderPayments { get; set; } = new List<OrderPayment>();

    public virtual ICollection<OrderShipment> OrderShipments { get; set; } = new List<OrderShipment>();

    public virtual ICollection<OrderStatusHistory> OrderStatusHistories { get; set; } = new List<OrderStatusHistory>();

    public virtual Realm Realm { get; set; }

    public virtual UserEntity User { get; set; }
}
