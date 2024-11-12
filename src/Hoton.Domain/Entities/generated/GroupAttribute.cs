using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class GroupAttribute
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string Value { get; set; }

    public string GroupId { get; set; }

    public virtual KeycloakGroup Group { get; set; }
}
