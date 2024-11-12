using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class OfflineClientSession
{
    public string UserSessionId { get; set; }

    public string ClientId { get; set; }

    public string OfflineFlag { get; set; }

    public int? Timestamp { get; set; }

    public string Data { get; set; }

    public string ClientStorageProvider { get; set; }

    public string ExternalClientId { get; set; }

    public int? Version { get; set; }
}
