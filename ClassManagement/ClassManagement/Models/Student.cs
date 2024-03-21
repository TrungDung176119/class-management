using System;
using System.Collections.Generic;

namespace ClassManagement.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string? FullName { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Gender { get; set; }

    public string? ContactInfo { get; set; }

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual ICollection<Mark> Marks { get; set; } = new List<Mark>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
