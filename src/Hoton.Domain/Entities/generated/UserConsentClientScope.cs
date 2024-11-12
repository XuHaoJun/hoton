using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class UserConsentClientScope
{
    public string UserConsentId { get; set; }

    public string ScopeId { get; set; }

    public virtual UserConsent UserConsent { get; set; }
}
