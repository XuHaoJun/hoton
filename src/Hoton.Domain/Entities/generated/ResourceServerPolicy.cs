using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class ResourceServerPolicy
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Type { get; set; }

    public short? DecisionStrategy { get; set; }

    public short? Logic { get; set; }

    public string ResourceServerId { get; set; }

    public string Owner { get; set; }

    public virtual ICollection<PolicyConfig> PolicyConfigs { get; set; } = new List<PolicyConfig>();

    public virtual ResourceServer ResourceServer { get; set; }

    public virtual ICollection<ResourceServerPermTicket> ResourceServerPermTickets { get; set; } = new List<ResourceServerPermTicket>();

    public virtual ICollection<ResourceServerPolicy> AssociatedPolicies { get; set; } = new List<ResourceServerPolicy>();

    public virtual ICollection<ResourceServerPolicy> Policies { get; set; } = new List<ResourceServerPolicy>();

    public virtual ICollection<ResourceServerResource> Resources { get; set; } = new List<ResourceServerResource>();

    public virtual ICollection<ResourceServerScope> Scopes { get; set; } = new List<ResourceServerScope>();
}
