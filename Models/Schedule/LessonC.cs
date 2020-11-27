using ScheduleGenerator.Models.Schedule.Interfaces;

namespace ScheduleGenerator.Models.Schedule
{
    class LessonC : ILesson
    {
        public DayOfWeekC DayOfWeek { get; set; }
        public int Number { get; set; }
        public ISubject Subject { get; set; }
    }
}
