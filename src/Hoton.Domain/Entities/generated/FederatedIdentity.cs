using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class FederatedIdentity
{
    public string IdentityProvider { get; set; }

    public string RealmId { get; set; }

    public string FederatedUserId { get; set; }

    public string FederatedUsername { get; set; }

    public string Token { get; set; }

    public string UserId { get; set; }

    public virtual UserEntity User { get; set; }
}
