using Microsoft.Xaml.Behaviors;
using System.Windows;
using System.Windows.Controls;

namespace ScheduleGenerator.Behaviours
{
    class MaximizeWindowBehavior : Behavior<Button>
    {
        protected override void OnAttached()
        {
            AssociatedObject.Click += OnMouseClick;
        }

        private void OnMouseClick(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(AssociatedObject).WindowState = Window.GetWindow(AssociatedObject).WindowState == WindowState.Maximized ?
                WindowState.Normal : WindowState.Maximized;
        }

        protected override void OnDetaching()
        {
            AssociatedObject.MouseDoubleClick -= OnMouseClick;
        }
    }
}
