using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class BrokerLink
{
    public string IdentityProvider { get; set; }

    public string StorageProviderId { get; set; }

    public string RealmId { get; set; }

    public string BrokerUserId { get; set; }

    public string BrokerUsername { get; set; }

    public string Token { get; set; }

    public string UserId { get; set; }
}
