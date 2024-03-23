using System;
using System.Collections.Generic;

namespace Class_Management.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int? ClassStudentId { get; set; }

    public DateTime? PaymentDate { get; set; }

    public decimal? Amount { get; set; }

    public string? PaymentMethod { get; set; }

    public int? PaymentStatus { get; set; }

    public virtual ClassStudent? ClassStudent { get; set; }
}
