using Microsoft.Extensions.DependencyInjection;
using ScheduleGenerator.Models.Schedule;
using ScheduleGenerator.Models.Schedule.Interfaces;

namespace ScheduleGenerator.Models
{
    static class ModelRegistrator
    {
        public static IServiceCollection AddModels(this IServiceCollection services) => services
            .AddTransient<ISubject, Subject>()
            .AddTransient<ISubjects, SubjectsC>()
            .AddTransient<ILesson, LessonC>()
            .AddTransient<ILessons, LessonsC>()
            .AddTransient<ITeacher, TeacherC>()
            .AddTransient<ITeachers, TeachersC>()
            .AddTransient<IDay, DayC>()
            .AddTransient<IWeek, WeekC>()
            .AddTransient<IGroup, GroupC>()
            ;
    }
}
