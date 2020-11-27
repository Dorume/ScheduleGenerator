using ScheduleGenerator.Models.Schedule.Interfaces;
using System.Collections.Generic;

namespace ScheduleGenerator.Models.Schedule
{
    class LessonsC : ILessons
    {
        public List<ILesson> Lessons { get; set; }

        public LessonsC()
        {
            Lessons = new List<ILesson>();
        }
    }
}
