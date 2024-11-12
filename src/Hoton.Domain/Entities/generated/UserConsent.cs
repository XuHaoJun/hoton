using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class UserConsent
{
    public string Id { get; set; }

    public string ClientId { get; set; }

    public string UserId { get; set; }

    public long? CreatedDate { get; set; }

    public long? LastUpdatedDate { get; set; }

    public string ClientStorageProvider { get; set; }

    public string ExternalClientId { get; set; }

    public virtual UserEntity User { get; set; }

    public virtual ICollection<UserConsentClientScope> UserConsentClientScopes { get; set; } = new List<UserConsentClientScope>();
}
