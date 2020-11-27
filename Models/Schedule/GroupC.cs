using ScheduleGenerator.Models.Schedule.Interfaces;

namespace ScheduleGenerator.Models.Schedule
{
    class GroupC : IGroup
    {
        public string Name { get; set; }
        public ITeachers Teachers { get; set; }
        public ISubjects Subjects { get; set; }
        public int MaxSubjectsAtDay { get; set; }
    }
}
