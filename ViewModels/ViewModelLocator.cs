using Microsoft.Extensions.DependencyInjection;

namespace ScheduleGenerator.ViewModels
{
    class ViewModelLocator
    {
        public MainViewModel MainViewModel => App.Services.GetRequiredService<MainViewModel>();
    }
}
