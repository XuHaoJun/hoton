using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class IdentityProviderConfig
{
    public string IdentityProviderId { get; set; }

    public string Value { get; set; }

    public string Name { get; set; }

    public virtual IdentityProvider IdentityProvider { get; set; }
}
