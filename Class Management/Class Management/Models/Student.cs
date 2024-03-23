using System;
using System.Collections.Generic;

namespace Class_Management.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string? FullName { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Gender { get; set; }

    public string? ContactInfo { get; set; }

    public virtual ICollection<ClassStudent> ClassStudents { get; set; } = new List<ClassStudent>();
}
