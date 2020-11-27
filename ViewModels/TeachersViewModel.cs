using ScheduleGenerator.ViewModels.Base;

namespace ScheduleGenerator.ViewModels
{
    class TeachersViewModel : ViewModel
    {
        #region Свойства
        #region Текст
        private string _Title = "Teachers";
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion
        #endregion
    }
}
