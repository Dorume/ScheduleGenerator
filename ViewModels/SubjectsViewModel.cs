using ScheduleGenerator.ViewModels.Base;

namespace ScheduleGenerator.ViewModels
{
    class SubjectsViewModel : ViewModel
    {
        #region Свойства
        #region Текст
        private string _Title = "Subjects";
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion
        #endregion
    }
}
