using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class Org
{
    public string Id { get; set; }

    public bool Enabled { get; set; }

    public string RealmId { get; set; }

    public string GroupId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Alias { get; set; }

    public string RedirectUrl { get; set; }
}
