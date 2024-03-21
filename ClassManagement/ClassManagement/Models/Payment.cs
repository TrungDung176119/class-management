using System;
using System.Collections.Generic;

namespace ClassManagement.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int? StudentId { get; set; }

    public DateTime? PaymentDate { get; set; }

    public decimal? Amount { get; set; }

    public string? PaymentMethod { get; set; }

    public int? PaymentStatus { get; set; }

    public virtual Student? Student { get; set; }
}
