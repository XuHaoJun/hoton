using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class GroupRoleMapping
{
    public string RoleId { get; set; }

    public string GroupId { get; set; }

    public virtual KeycloakGroup Group { get; set; }
}
