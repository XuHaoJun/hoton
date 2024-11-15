﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Hoton.Domain.Entities.generated;

public partial class Product
{
    public Guid Id { get; set; }

    public string RealmId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public List<LTree> Categories { get; set; }

    public List<string> Tags { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? SnapshotVersion { get; set; }

    public virtual ICollection<ProductSku> ProductSkus { get; set; } = new List<ProductSku>();

    public virtual Realm Realm { get; set; }
}
