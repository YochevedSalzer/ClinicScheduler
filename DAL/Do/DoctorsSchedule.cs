using System;
using System.Collections.Generic;

namespace DAL.Do;

public partial class DoctorsSchedule
{
    public int Code { get; set; }

    public int DoctorCode { get; set; }

    public int DayInTheWeek { get; set; }

    public TimeSpan StartTime { get; set; }

    public TimeSpan FinishTime { get; set; }

    public virtual Doctor DoctorCodeNavigation { get; set; } = null!;
}
