﻿using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class SnapshotProductSku
{
    public Guid Id { get; set; }

    public Guid ProductId { get; set; }

    public int? StockQuantity { get; set; }

    public int? SafetyStock { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime SnapshotVersion { get; set; }
}
