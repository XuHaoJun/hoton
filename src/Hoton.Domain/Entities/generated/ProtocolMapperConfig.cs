using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class ProtocolMapperConfig
{
    public string ProtocolMapperId { get; set; }

    public string Value { get; set; }

    public string Name { get; set; }

    public virtual ProtocolMapper ProtocolMapper { get; set; }
}
