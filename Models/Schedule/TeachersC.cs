using ScheduleGenerator.Models.Schedule.Interfaces;
using System.Collections.Generic;

namespace ScheduleGenerator.Models.Schedule
{
    class TeachersC : ITeachers
    {
        public List<ITeacher> Teachers { get; set; }

        public TeachersC()
        {
            Teachers = new List<ITeacher>();
        }
    }
}
