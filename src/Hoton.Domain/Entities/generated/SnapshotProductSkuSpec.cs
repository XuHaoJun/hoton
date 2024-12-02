using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class SnapshotProductSkuSpec
{
    public Guid Id { get; set; }

    public Guid ProductSkuId { get; set; }

    public string SpecName { get; set; }

    public string SpecValue { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? SnapshotVersion { get; set; }
}
