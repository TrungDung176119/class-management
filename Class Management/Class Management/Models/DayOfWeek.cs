using System;
using System.Collections.Generic;

namespace Class_Management.Models;

public partial class DayOfWeek
{
    public int DayOfWeekId { get; set; }

    public string? DayName { get; set; }

    public virtual ICollection<ClassSchedule> ClassSchedules { get; set; } = new List<ClassSchedule>();
}
