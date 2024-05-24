using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bo
{
    public class DoctorSchedule
    {

        public int DoctorCode { get; set; }

        public int DayInTheWeek { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan FinishTime { get; set; }

        public int AppointmentDuration { get; set; }

        //public virtual Doctor DoctorCodeNavigation { get; set; } = null!;



    }
}
