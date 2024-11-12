using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Hoton.Domain.Entities.generated;

public partial class ProductCategory
{
    public Guid Id { get; set; }

    public LTree NamePath { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
