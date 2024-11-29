using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class Cart
{
    public Guid Id { get; set; }

    public string UserId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    public virtual UserEntity User { get; set; }
}
