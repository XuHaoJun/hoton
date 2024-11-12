using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class SnapshotProduct
{
    public Guid Id { get; set; }

    public DateTime SnapshotVersion { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
