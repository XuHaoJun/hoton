using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class ClientScopeRoleMapping
{
    public string ScopeId { get; set; }

    public string RoleId { get; set; }

    public virtual ClientScope Scope { get; set; }
}
