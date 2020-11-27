using Microsoft.Xaml.Behaviors;
using System.Windows;
using System.Windows.Input;

namespace ScheduleGenerator.Behaviours
{
    public class MouseDragWindow : Behavior<UIElement>
    {
        private Point _StartPoint;
        protected override void OnAttached()
        {
            AssociatedObject.MouseLeftButtonDown += OnLeftButtonDown;
        }


        protected override void OnDetaching()
        {
            AssociatedObject.MouseLeftButtonDown -= OnLeftButtonDown;
            AssociatedObject.MouseMove -= OnMouseMove;
            AssociatedObject.MouseUp -= OnMouseUp;
        }

        private void OnLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _StartPoint = e.GetPosition(AssociatedObject);
            AssociatedObject.CaptureMouse();
            AssociatedObject.MouseMove += OnMouseMove;
            AssociatedObject.MouseUp += OnMouseUp;
        }

        private void OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            AssociatedObject.MouseMove -= OnMouseMove;
            AssociatedObject.MouseUp -= OnMouseUp;
            AssociatedObject.ReleaseMouseCapture();
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            var obj = AssociatedObject;
            var current_pos = e.GetPosition(obj);

            Point delta = ((Point)(current_pos - _StartPoint));

            obj.SetValue(Window.LeftProperty, AssociatedObject.PointToScreen(delta).X);
            obj.SetValue(Window.TopProperty, AssociatedObject.PointToScreen(delta).Y);
        }
    }
}
