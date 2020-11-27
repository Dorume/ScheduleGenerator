using ScheduleGenerator.Models.Schedule.Interfaces;

namespace ScheduleGenerator.Models.Schedule
{
    class TeacherC : ITeacher
    {
        public string Name { get; set; }
        public ISubjects Subjects { get; set; }
        public IWeek Days { get; set; }
        public ILessons Lessons { get; set; }
    }
}
