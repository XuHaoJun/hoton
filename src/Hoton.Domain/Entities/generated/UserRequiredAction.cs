using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class UserRequiredAction
{
    public string UserId { get; set; }

    public string RequiredAction { get; set; }

    public virtual UserEntity User { get; set; }
}
