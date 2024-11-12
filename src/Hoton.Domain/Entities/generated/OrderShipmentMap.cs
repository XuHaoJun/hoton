using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class OrderShipmentMap
{
    public Guid OrderId { get; set; }

    public Guid ShipmentId { get; set; }

    public string FlowType { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Order Order { get; set; }

    public virtual Shipment Shipment { get; set; }
}
