using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class EventEntity
{
    public string Id { get; set; }

    public string ClientId { get; set; }

    public string DetailsJson { get; set; }

    public string Error { get; set; }

    public string IpAddress { get; set; }

    public string RealmId { get; set; }

    public string SessionId { get; set; }

    public long? EventTime { get; set; }

    public string Type { get; set; }

    public string UserId { get; set; }

    public string DetailsJsonLongValue { get; set; }
}
