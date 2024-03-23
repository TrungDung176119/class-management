using System;
using System.Collections.Generic;

namespace Class_Management.Models;

public partial class ClassStudent
{
    public int ClassStudentId { get; set; }

    public int? ClassId { get; set; }

    public int? StudentId { get; set; }

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual Class? Class { get; set; }

    public virtual ICollection<Mark> Marks { get; set; } = new List<Mark>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual Student? Student { get; set; }
}
