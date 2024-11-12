using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class Product
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? SnapshotVersion { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<ProductSku> ProductSkus { get; set; } = new List<ProductSku>();

    public virtual ICollection<ProductCategory> Categories { get; set; } = new List<ProductCategory>();
}
