using System;
using System.Collections.Generic;

namespace Class_Management.Models;

public partial class TimeOfDay
{
    public int TimeOfDayId { get; set; }

    public string? TimeSlot { get; set; }

    public virtual ICollection<ClassSchedule> ClassSchedules { get; set; } = new List<ClassSchedule>();
}
