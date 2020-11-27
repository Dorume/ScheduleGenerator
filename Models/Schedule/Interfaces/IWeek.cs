using System.Collections.Generic;

namespace ScheduleGenerator.Models.Schedule.Interfaces
{
    interface IWeek
    {
        List<IDay> Week { get; set; }
    }
}
