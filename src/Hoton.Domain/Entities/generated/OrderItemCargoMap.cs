using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class OrderItemCargoMap
{
    public Guid OrderItemId { get; set; }

    public Guid OrderShipmentCargoId { get; set; }

    public int? Quantity { get; set; }

    public virtual OrderItem OrderItem { get; set; }

    public virtual OrderShipmentCargo OrderShipmentCargo { get; set; }
}
