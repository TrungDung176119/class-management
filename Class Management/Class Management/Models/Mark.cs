using System;
using System.Collections.Generic;

namespace Class_Management.Models;

public partial class Mark
{
    public int MarkId { get; set; }

    public int? ClassId { get; set; }

    public int? StudentId { get; set; }

    public DateTime? MarkDate { get; set; }

    public string? Subject { get; set; }

    public decimal? Mark1 { get; set; }

    public virtual Class? Class { get; set; }

    public virtual Student? Student { get; set; }
}
