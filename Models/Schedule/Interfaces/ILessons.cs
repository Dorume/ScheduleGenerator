using System.Collections.Generic;

namespace ScheduleGenerator.Models.Schedule.Interfaces
{
    interface ILessons
    {
        List<ILesson> Lessons { get; set; }
    }
}
