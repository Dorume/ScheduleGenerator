using ScheduleGenerator.Models.Schedule.Interfaces;
using System.Collections.Generic;

namespace ScheduleGenerator.Models.Schedule
{
    class SubjectsC : ISubjects
    {
        public List<ISubject> Subjects { get; set; }

        public SubjectsC()
        {
            Subjects = new List<ISubject>();
        }
    }
}
