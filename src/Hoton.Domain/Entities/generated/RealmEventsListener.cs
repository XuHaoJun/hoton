using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class RealmEventsListener
{
    public string RealmId { get; set; }

    public string Value { get; set; }

    public virtual Realm Realm { get; set; }
}
