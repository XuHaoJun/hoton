using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class CargoProductSkuQuantityMap
{
    public Guid? CargoId { get; set; }

    public Guid? ProductSkuId { get; set; }

    public int? Quantity { get; set; }

    public virtual Cargo Cargo { get; set; }

    public virtual ProductSku ProductSku { get; set; }
}
