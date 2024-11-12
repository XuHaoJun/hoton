using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class ClientInitialAccess
{
    public string Id { get; set; }

    public string RealmId { get; set; }

    public int? Timestamp { get; set; }

    public int? Expiration { get; set; }

    public int? Count { get; set; }

    public int? RemainingCount { get; set; }

    public virtual Realm Realm { get; set; }
}
