using System;
using System.Collections.Generic;

namespace Class_Management.Models;

public partial class Class
{
    public int ClassId { get; set; }

    public string? ClassName { get; set; }

    public DateTime? ClassStartDate { get; set; }

    public DateTime? ClassEndDate { get; set; }

    public int? ClassStatus { get; set; }

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual ICollection<ClassSchedule> ClassSchedules { get; set; } = new List<ClassSchedule>();

    public virtual ICollection<Mark> Marks { get; set; } = new List<Mark>();
}
