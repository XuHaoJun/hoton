using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class AuthenticationFlow
{
    public string Id { get; set; }

    public string Alias { get; set; }

    public string Description { get; set; }

    public string RealmId { get; set; }

    public string ProviderId { get; set; }

    public bool TopLevel { get; set; }

    public bool BuiltIn { get; set; }

    public virtual ICollection<AuthenticationExecution> AuthenticationExecutions { get; set; } = new List<AuthenticationExecution>();

    public virtual Realm Realm { get; set; }
}
