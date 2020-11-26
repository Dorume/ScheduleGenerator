using Microsoft.Extensions.DependencyInjection;

namespace ScheduleGenerator.ViewModels
{
    static class ViewModelRegistrator
    {
        public static IServiceCollection AddViewModel(this IServiceCollection services) => services
            .AddSingleton<MainViewModel>()
            ;
    }
}
