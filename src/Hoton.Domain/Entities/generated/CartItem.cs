using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class CartItem
{
    public Guid Id { get; set; }

    public Guid CartId { get; set; }

    public Guid ProductSkuId { get; set; }

    public int Quantity { get; set; }

    public decimal Price { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Cart Cart { get; set; }

    public virtual ProductSku ProductSku { get; set; }
}
