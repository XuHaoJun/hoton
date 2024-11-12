using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class ResourceServerResource
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string Type { get; set; }

    public string IconUri { get; set; }

    public string Owner { get; set; }

    public string ResourceServerId { get; set; }

    public bool OwnerManagedAccess { get; set; }

    public string DisplayName { get; set; }

    public virtual ICollection<ResourceAttribute> ResourceAttributes { get; set; } = new List<ResourceAttribute>();

    public virtual ResourceServer ResourceServer { get; set; }

    public virtual ICollection<ResourceServerPermTicket> ResourceServerPermTickets { get; set; } = new List<ResourceServerPermTicket>();

    public virtual ICollection<ResourceUri> ResourceUris { get; set; } = new List<ResourceUri>();

    public virtual ICollection<ResourceServerPolicy> Policies { get; set; } = new List<ResourceServerPolicy>();

    public virtual ICollection<ResourceServerScope> Scopes { get; set; } = new List<ResourceServerScope>();
}
