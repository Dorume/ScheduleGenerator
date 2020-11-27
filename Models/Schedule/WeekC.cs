using ScheduleGenerator.Models.Schedule.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleGenerator.Models.Schedule
{
    class WeekC : IWeek
    {
        public List<IDay> Week { get; set; }

        //private IDay Day { get; set; }
        public WeekC(IDay day)
        {
            //Day = day;
            Week = new List<IDay>();
        }
    }
}
