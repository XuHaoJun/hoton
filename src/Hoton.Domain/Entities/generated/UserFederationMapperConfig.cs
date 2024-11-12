using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class UserFederationMapperConfig
{
    public string UserFederationMapperId { get; set; }

    public string Value { get; set; }

    public string Name { get; set; }

    public virtual UserFederationMapper UserFederationMapper { get; set; }
}
