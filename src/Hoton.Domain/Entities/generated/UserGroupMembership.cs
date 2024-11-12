using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class UserGroupMembership
{
    public string GroupId { get; set; }

    public string UserId { get; set; }

    public string MembershipType { get; set; }

    public virtual UserEntity User { get; set; }
}
