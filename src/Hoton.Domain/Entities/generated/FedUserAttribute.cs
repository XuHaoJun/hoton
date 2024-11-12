using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class FedUserAttribute
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string UserId { get; set; }

    public string RealmId { get; set; }

    public string StorageProviderId { get; set; }

    public string Value { get; set; }

    public byte[] LongValueHash { get; set; }

    public byte[] LongValueHashLowerCase { get; set; }

    public string LongValue { get; set; }
}
