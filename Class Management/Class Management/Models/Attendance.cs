using System;
using System.Collections.Generic;

namespace Class_Management.Models;

public partial class Attendance
{
    public int AttendanceId { get; set; }

    public int? ClassStudentId { get; set; }

    public DateTime? AttendanceDate { get; set; }

    public int? AttendanceStatus { get; set; }

    public virtual ClassStudent? ClassStudent { get; set; }
}
