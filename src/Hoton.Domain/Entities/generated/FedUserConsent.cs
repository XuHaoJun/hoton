using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class FedUserConsent
{
    public string Id { get; set; }

    public string ClientId { get; set; }

    public string UserId { get; set; }

    public string RealmId { get; set; }

    public string StorageProviderId { get; set; }

    public long? CreatedDate { get; set; }

    public long? LastUpdatedDate { get; set; }

    public string ClientStorageProvider { get; set; }

    public string ExternalClientId { get; set; }
}
