using System.Collections.Generic;

namespace ScheduleGenerator.Models.Schedule.Interfaces
{
    interface ITeacher
    {
        string Name { get; set; }
        ISubjects Subjects { get; set; }
        IWeek Days { get; set; }
        ILessons Lessons { get; set; }
    }
}
