using System;
using System.Collections.Generic;

namespace Class_Management.Models;

public partial class Attendance
{
    public int AttendanceId { get; set; }

    public int? ClassId { get; set; }

    public int? StudentId { get; set; }

    public DateTime? AttendanceDate { get; set; }

    public int? AttendanceStatus { get; set; }

    public virtual Class? Class { get; set; }

    public virtual Student? Student { get; set; }
}
