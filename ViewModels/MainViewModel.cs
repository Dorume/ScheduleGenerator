using ScheduleGenerator.Infrastructure.Commands;
using ScheduleGenerator.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ScheduleGenerator.ViewModels
{
    class MainViewModel : ViewModel
    {
        #region Свойства
        private string _Title = "Some title";
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion

        #region Команды
        #region Команда перетаскивания окна
        public ICommand DragMoveWindowCommand { get; }
        private bool CanDragMoveWindowExecute(object parameter) => true;
        private void OnDragMoveWindowExecuted(object parameter) => (parameter as Window).DragMove();
        #endregion
        #region Команда выхода из приложения
        public ICommand CloseApplicationCommand { get; }
        private bool CanCloseApplicationCommandExecute(object parameter) => true;
        private void OnCloseApplicationCommandExecuted(object parameter) => App.Current.Shutdown();
        #endregion
        #endregion
        public MainViewModel()
        {
            #region Инициализация команд
            DragMoveWindowCommand = new LambdaCommand(OnDragMoveWindowExecuted, CanDragMoveWindowExecute);
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            #endregion
        }
    }
}
