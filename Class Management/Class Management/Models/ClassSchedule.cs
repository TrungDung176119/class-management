using System;
using System.Collections.Generic;

namespace Class_Management.Models;

public partial class ClassSchedule
{
    public int ClassId { get; set; }

    public int DayOfWeekId { get; set; }

    public int TimeOfDayId { get; set; }

    public virtual Class Class { get; set; } = null!;

    public virtual DayOfWeek DayOfWeek { get; set; } = null!;

    public virtual TimeOfDay TimeOfDay { get; set; } = null!;
}
