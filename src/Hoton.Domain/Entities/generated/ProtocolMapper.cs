using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class ProtocolMapper
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string Protocol { get; set; }

    public string ProtocolMapperName { get; set; }

    public string ClientId { get; set; }

    public string ClientScopeId { get; set; }

    public virtual Client Client { get; set; }

    public virtual ClientScope ClientScope { get; set; }

    public virtual ICollection<ProtocolMapperConfig> ProtocolMapperConfigs { get; set; } = new List<ProtocolMapperConfig>();
}
