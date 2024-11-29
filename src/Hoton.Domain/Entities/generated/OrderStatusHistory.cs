using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class OrderStatusHistory
{
    public Guid Id { get; set; }

    public Guid OrderId { get; set; }

    public string FromStatus { get; set; }

    public string ToStatus { get; set; }

    public string Reason { get; set; }

    public string ReasonData { get; set; }

    public string CreaterId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Order Order { get; set; }
}
