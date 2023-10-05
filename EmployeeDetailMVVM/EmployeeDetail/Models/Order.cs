using System;
using System.Collections.Generic;

namespace EmployeeDetail02.Model;

public partial class Order
{
    public string OrderId { get; set; } = null!;

    public DateTime? Date { get; set; }

    public string? CustomerId { get; set; }

    public decimal? TotalPayment { get; set; }
}
