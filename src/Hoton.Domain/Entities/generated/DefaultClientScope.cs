using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class DefaultClientScope
{
    public string RealmId { get; set; }

    public string ScopeId { get; set; }

    public bool DefaultScope { get; set; }

    public virtual Realm Realm { get; set; }
}
