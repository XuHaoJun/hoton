using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class RealmRequiredCredential
{
    public string Type { get; set; }

    public string FormLabel { get; set; }

    public bool Input { get; set; }

    public bool Secret { get; set; }

    public string RealmId { get; set; }

    public virtual Realm Realm { get; set; }
}
