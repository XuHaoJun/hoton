using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class OrderPayment
{
    public Guid Id { get; set; }

    public string RealmId { get; set; }

    public Guid? OrderId { get; set; }

    public string PaymentNumber { get; set; }

    public decimal Amount { get; set; }

    public string Status { get; set; }

    public string PaymentMethod { get; set; }

    public string MerchantId { get; set; }

    public string ServiceProvider { get; set; }

    public string ReturnUrl { get; set; }

    public string OrderResultUrl { get; set; }

    public string CheckMacValue { get; set; }

    public string AtmPayNo { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Order Order { get; set; }

    public virtual Realm Realm { get; set; }
}
