using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class ProductShipmentConfig
{
    public Guid Id { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? RealmOrderShipmentConfigId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Product Product { get; set; }

    public virtual RealmOrderShipmentConfig RealmOrderShipmentConfig { get; set; }
}
