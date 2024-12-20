﻿using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class Cargo
{
    public Guid Id { get; set; }

    public Guid? ShipmentId { get; set; }

    public string TrackingNumber { get; set; }

    public decimal? Length { get; set; }

    public decimal? Width { get; set; }

    public decimal? Height { get; set; }

    public decimal? Weight { get; set; }

    public decimal? Volume { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Shipment Shipment { get; set; }
}
