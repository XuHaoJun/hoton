using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class ResourceServerScope
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string IconUri { get; set; }

    public string ResourceServerId { get; set; }

    public string DisplayName { get; set; }

    public virtual ResourceServer ResourceServer { get; set; }

    public virtual ICollection<ResourceServerPermTicket> ResourceServerPermTickets { get; set; } = new List<ResourceServerPermTicket>();

    public virtual ICollection<ResourceServerPolicy> Policies { get; set; } = new List<ResourceServerPolicy>();

    public virtual ICollection<ResourceServerResource> Resources { get; set; } = new List<ResourceServerResource>();
}
