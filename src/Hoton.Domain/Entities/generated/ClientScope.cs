using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class ClientScope
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string RealmId { get; set; }

    public string Description { get; set; }

    public string Protocol { get; set; }

    public virtual ICollection<ClientScopeAttribute> ClientScopeAttributes { get; set; } = new List<ClientScopeAttribute>();

    public virtual ICollection<ClientScopeRoleMapping> ClientScopeRoleMappings { get; set; } = new List<ClientScopeRoleMapping>();

    public virtual ICollection<ProtocolMapper> ProtocolMappers { get; set; } = new List<ProtocolMapper>();
}
