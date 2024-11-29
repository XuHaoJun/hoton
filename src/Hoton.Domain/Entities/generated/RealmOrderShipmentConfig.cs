using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class RealmOrderShipmentConfig
{
    public Guid Id { get; set; }

    public string RealmId { get; set; }

    public string DisplayName { get; set; }

    public string ShipmentServiceProvider { get; set; }

    public decimal MinOrderAmount { get; set; }

    public string TemperatureZone { get; set; }

    public decimal ShipmentFee { get; set; }

    public string Country { get; set; }

    public string PayConditions { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ProductShipmentConfig> ProductShipmentConfigs { get; set; } = new List<ProductShipmentConfig>();

    public virtual Realm Realm { get; set; }
}
