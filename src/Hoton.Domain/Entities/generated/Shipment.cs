using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class Shipment
{
    public Guid Id { get; set; }

    public string TrackingNumber { get; set; }

    public string Status { get; set; }

    public string ServiceProvider { get; set; }

    public string ServiceType { get; set; }

    public string TemperatureZone { get; set; }

    public string SenderName { get; set; }

    public string SenderPhone { get; set; }

    public string ReceiverName { get; set; }

    public string ReceiverPhone { get; set; }

    public string ReceiverAddress { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Cargo> Cargos { get; set; } = new List<Cargo>();
}
