using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class RoleAttribute
{
    public string Id { get; set; }

    public string RoleId { get; set; }

    public string Name { get; set; }

    public string Value { get; set; }

    public virtual KeycloakRole Role { get; set; }
}
