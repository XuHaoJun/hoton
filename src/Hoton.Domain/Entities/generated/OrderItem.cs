using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class OrderItem
{
    public Guid Id { get; set; }

    public Guid OrderId { get; set; }

    public Guid ProductSkuId { get; set; }

    public DateTime? SnapshotVersion { get; set; }

    public int? Quantity { get; set; }

    public decimal Price { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Order Order { get; set; }

    public virtual ProductSku ProductSku { get; set; }
}
