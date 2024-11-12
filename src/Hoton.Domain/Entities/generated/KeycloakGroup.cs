using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class KeycloakGroup
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string ParentGroup { get; set; }

    public string RealmId { get; set; }

    public int Type { get; set; }

    public virtual ICollection<GroupAttribute> GroupAttributes { get; set; } = new List<GroupAttribute>();

    public virtual ICollection<GroupRoleMapping> GroupRoleMappings { get; set; } = new List<GroupRoleMapping>();
}
