using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class ResourceServerPermTicket
{
    public string Id { get; set; }

    public string Owner { get; set; }

    public string Requester { get; set; }

    public long CreatedTimestamp { get; set; }

    public long? GrantedTimestamp { get; set; }

    public string ResourceId { get; set; }

    public string ScopeId { get; set; }

    public string ResourceServerId { get; set; }

    public string PolicyId { get; set; }

    public virtual ResourceServerPolicy Policy { get; set; }

    public virtual ResourceServerResource Resource { get; set; }

    public virtual ResourceServer ResourceServer { get; set; }

    public virtual ResourceServerScope Scope { get; set; }
}
