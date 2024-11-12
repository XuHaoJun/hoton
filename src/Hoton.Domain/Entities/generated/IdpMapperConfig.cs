using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class IdpMapperConfig
{
    public string IdpMapperId { get; set; }

    public string Value { get; set; }

    public string Name { get; set; }

    public virtual IdentityProviderMapper IdpMapper { get; set; }
}
