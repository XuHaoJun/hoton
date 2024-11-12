using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class FederatedUser
{
    public string Id { get; set; }

    public string StorageProviderId { get; set; }

    public string RealmId { get; set; }
}
