using ScheduleGenerator.ViewModels.Base;

namespace ScheduleGenerator.ViewModels
{
    class GroupsViewModel : ViewModel
    {
        #region Свойства
        #region Текст
        private string _Title = "Groups";
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion
        #endregion
    }
}
