using Microsoft.Xaml.Behaviors;
using System.Windows;
using System.Windows.Controls;

namespace ScheduleGenerator.Behaviours
{
    class MinimizeWindowBehavior : Behavior<Button>
    {
        protected override void OnAttached()
        {
            AssociatedObject.Click += OnMouseClick;
        }

        private void OnMouseClick(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(AssociatedObject).WindowState = Window.GetWindow(AssociatedObject).WindowState == WindowState.Minimized ?
                WindowState.Normal : WindowState.Minimized;
        }

        protected override void OnDetaching()
        {
            AssociatedObject.MouseDoubleClick -= OnMouseClick;
        }
    }
}
