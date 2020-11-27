using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleGenerator.Models.Schedule.Interfaces
{
    interface IGroup
    {
        string Name { get; set; }
        ITeachers Teachers { get; set; }
        ISubjects Subjects { get; set; }
        int MaxSubjectsAtDay { get; set; }
    }
}
