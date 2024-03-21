using System;
using System.Collections.Generic;

namespace ClassManagement.Models;

public partial class Class
{
    public int ClassId { get; set; }

    public string? ClassName { get; set; }

    public DateTime? ClassStartDate { get; set; }

    public DateTime? ClassEndDate { get; set; }

    public string? Schedule { get; set; }

    public int? ClassStatus { get; set; }

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual ICollection<Mark> Marks { get; set; } = new List<Mark>();
}
