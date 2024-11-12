using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class OfflineUserSession
{
    public string UserSessionId { get; set; }

    public string UserId { get; set; }

    public string RealmId { get; set; }

    public int CreatedOn { get; set; }

    public string OfflineFlag { get; set; }

    public string Data { get; set; }

    public int LastSessionRefresh { get; set; }

    public string BrokerSessionId { get; set; }

    public int? Version { get; set; }
}
