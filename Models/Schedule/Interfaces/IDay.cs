namespace ScheduleGenerator.Models.Schedule.Interfaces
{
    interface IDay
    {
        DayOfWeekC Day { get; set; }
        int MaxSubjects { get; set; }
    }
}
