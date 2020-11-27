using ScheduleGenerator.Models.Schedule.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleGenerator.Models.Schedule
{
    class DayC : IDay
    {
        public DayOfWeekC Day { get; set; }
        public int MaxSubjects { get; set; }
    }
}
