using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class ScopeMapping
{
    public string ClientId { get; set; }

    public string RoleId { get; set; }

    public virtual Client Client { get; set; }
}
