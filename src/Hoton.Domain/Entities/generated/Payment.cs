using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class Payment
{
    public Guid Id { get; set; }

    public string PaymentNumber { get; set; }

    public decimal Amount { get; set; }

    public string Status { get; set; }

    public string PaymentMethod { get; set; }

    public string ServiceProvider { get; set; }

    public string ReturnUrl { get; set; }

    public string OrderResultUrl { get; set; }

    public string CheckMacValue { get; set; }

    public string AtmPayNo { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
