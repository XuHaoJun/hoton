using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class FedUserGroupMembership
{
    public string GroupId { get; set; }

    public string UserId { get; set; }

    public string RealmId { get; set; }

    public string StorageProviderId { get; set; }
}
