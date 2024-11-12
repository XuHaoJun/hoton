using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class UserRoleMapping
{
    public string RoleId { get; set; }

    public string UserId { get; set; }

    public virtual UserEntity User { get; set; }
}
