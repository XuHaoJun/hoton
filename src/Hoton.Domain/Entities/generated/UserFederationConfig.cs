using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class UserFederationConfig
{
    public string UserFederationProviderId { get; set; }

    public string Value { get; set; }

    public string Name { get; set; }

    public virtual UserFederationProvider UserFederationProvider { get; set; }
}
