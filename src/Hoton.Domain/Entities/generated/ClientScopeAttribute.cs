using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class ClientScopeAttribute
{
    public string ScopeId { get; set; }

    public string Value { get; set; }

    public string Name { get; set; }

    public virtual ClientScope Scope { get; set; }
}
