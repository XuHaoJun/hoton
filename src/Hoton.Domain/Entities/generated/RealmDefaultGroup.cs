using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class RealmDefaultGroup
{
    public string RealmId { get; set; }

    public string GroupId { get; set; }

    public virtual Realm Realm { get; set; }
}
