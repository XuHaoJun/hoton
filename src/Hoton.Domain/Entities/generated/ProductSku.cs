﻿using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class ProductSku
{
    public Guid Id { get; set; }

    public Guid ProductId { get; set; }

    public int? StockQuantity { get; set; }

    public int? SafetyStock { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? SnapshotVersion { get; set; }

    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual Product Product { get; set; }

    public virtual ICollection<ProductSkuSpec> ProductSkuSpecs { get; set; } = new List<ProductSkuSpec>();
}
