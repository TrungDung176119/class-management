using System;
using System.Collections.Generic;

namespace Class_Management.Models;

public partial class Mark
{
    public int MarkId { get; set; }

    public int? ClassStudentId { get; set; }

    public DateTime? MarkDate { get; set; }

    public string? Subject { get; set; }

    public decimal? Mark1 { get; set; }

    public virtual ClassStudent? ClassStudent { get; set; }
}
