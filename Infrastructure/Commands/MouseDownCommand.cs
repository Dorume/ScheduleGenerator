using ScheduleGenerator.Infrastructure.Commands.Base;
using System;
using System.Windows;
using System.Windows.Markup;

namespace ScheduleGenerator.Infrastructure.Commands
{
    class MouseDownCommand : Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter) => (parameter as Window).DragMove();
    }

    //class MouseDownCommandExtension : MarkupExtension
    //{
    //    public override object ProvideValue(IServiceProvider serviceProvider)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
