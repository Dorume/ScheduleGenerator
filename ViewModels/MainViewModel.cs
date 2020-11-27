using Microsoft.Extensions.DependencyInjection;
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
        #region 
        private ViewModel _ViewModel;
        public ViewModel ViewModel
        {
            get => _ViewModel;
            set => Set(ref _ViewModel, value);
        }
        #endregion
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

        #region Смена страницы на "SubjectsView"
        public ICommand ChangePageToSubjectsViewCommand { get; }
        private bool CanChangePageToSubjectsViewCommandExecute(object parameter) => true;
        private void OnChangePageToSubjectsViewCommandExecuted(object parameter) =>
            ViewModel = App.Host.Services.GetRequiredService<SubjectsViewModel>();
        #endregion

        #region Смена страницы на "TeachersView"
        public ICommand ChangePageToTeachersViewCommand { get; }
        private bool CanChangePageToTeachersViewExecute(object parameter) => true;
        private void OnChangePageToTeachersViewExecuted(object parameter) =>
            ViewModel = App.Host.Services.GetRequiredService<TeachersViewModel>();
        #endregion
        #endregion
        public MainViewModel()
        {
            #region Инициализация команд
            DragMoveWindowCommand = new LambdaCommand(OnDragMoveWindowExecuted, CanDragMoveWindowExecute);
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            ChangePageToSubjectsViewCommand = new LambdaCommand(OnChangePageToSubjectsViewCommandExecuted, CanChangePageToSubjectsViewCommandExecute);
            ChangePageToTeachersViewCommand = new LambdaCommand(OnChangePageToTeachersViewExecuted, CanChangePageToTeachersViewExecute);
            #endregion
        }
    }
}
