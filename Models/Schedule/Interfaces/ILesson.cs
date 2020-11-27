using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleGenerator.Models.Schedule.Interfaces
{
    interface ILesson
    {
        DayOfWeekC DayOfWeek { get; set; } 
        int Number { get; set; }
        ISubject Subject { get; set; }
    }
}
