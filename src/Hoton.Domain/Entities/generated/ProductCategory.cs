using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Hoton.Domain.Entities.generated;

public partial class ProductCategory
{
    public Guid ProductId { get; set; }

    public LTree Category { get; set; }

    public bool? Enabled { get; set; }

    public virtual Product Product { get; set; }
}
