using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class Order
{
    public Guid Id { get; set; }

    public string TransactionNo { get; set; }

    public string CustomerName { get; set; }

    public decimal TotalAmount { get; set; }

    public decimal DeliveryFee { get; set; }

    public string Status { get; set; }

    public string UserId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<OrderShipmentMap> OrderShipmentMaps { get; set; } = new List<OrderShipmentMap>();

    public virtual ICollection<OrderStatusHistory> OrderStatusHistories { get; set; } = new List<OrderStatusHistory>();

    public virtual UserEntity User { get; set; }
}
