using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class AuthenticatorConfig
{
    public string Id { get; set; }

    public string Alias { get; set; }

    public string RealmId { get; set; }

    public virtual Realm Realm { get; set; }
}
