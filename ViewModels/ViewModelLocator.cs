using Microsoft.Extensions.DependencyInjection;

namespace ScheduleGenerator.ViewModels
{
    class ViewModelLocator
    {
        
        public MainViewModel MainViewModel => App.Services.GetRequiredService<MainViewModel>();
        public SubjectsViewModel SubjectsViewModel => App.Services.GetRequiredService<SubjectsViewModel>();
        public TeachersViewModel TeachersViewModel => App.Services.GetRequiredService<TeachersViewModel>();
        public GroupsViewModel GroupsViewModel => App.Services.GetRequiredService<GroupsViewModel>();

    }
}
