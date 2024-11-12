using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class ResourceServer
{
    public string Id { get; set; }

    public bool AllowRsRemoteMgmt { get; set; }

    public short PolicyEnforceMode { get; set; }

    public short DecisionStrategy { get; set; }

    public virtual ICollection<ResourceServerPermTicket> ResourceServerPermTickets { get; set; } = new List<ResourceServerPermTicket>();

    public virtual ICollection<ResourceServerPolicy> ResourceServerPolicies { get; set; } = new List<ResourceServerPolicy>();

    public virtual ICollection<ResourceServerResource> ResourceServerResources { get; set; } = new List<ResourceServerResource>();

    public virtual ICollection<ResourceServerScope> ResourceServerScopes { get; set; } = new List<ResourceServerScope>();
}
