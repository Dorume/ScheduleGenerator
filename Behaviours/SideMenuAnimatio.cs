using MaterialDesignThemes.Wpf.Transitions;
using Microsoft.Xaml.Behaviors;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ScheduleGenerator.Behaviours
{
    class SideMenuAnimatio : Behavior<ListView>
    {
        public static readonly DependencyProperty MarginSelectedMenuProperty =
            DependencyProperty.Register(
                nameof(MarginSelectedMenu),
                typeof(Thickness),
                typeof(SideMenuAnimatio),
                new PropertyMetadata(default(Thickness))
                );

        [Description("Поведение которое реализирует анимацию боковой менюшки")]
        public Thickness MarginSelectedMenu
        {
            get => (Thickness)GetValue(MarginSelectedMenuProperty);
            set => SetValue(MarginSelectedMenuProperty, value);
        }

        public SideMenuAnimatio()
        {
            MarginSelectedMenu = new Thickness(0, 100, 0, 0);
        }

        protected override void OnAttached()
        {
            AssociatedObject.SelectionChanged += OnSelectionChanged;

        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TransitioningContent cursor = FindMaterialDesign();
            if (cursor == null)
                return;
            cursor.OnApplyTemplate();
            MarginSelectedMenu = new Thickness(0, 100 + 60 * AssociatedObject.SelectedIndex, 0, 0);
        }

        private TransitioningContent FindMaterialDesign()
        {
            Grid obj = VisualTreeHelper.GetParent(AssociatedObject) as Grid;
            for(int index = 0; index < VisualTreeHelper.GetChildrenCount(obj); index++)
            {
                TransitioningContent cursor = VisualTreeHelper.GetChild(obj, index) as TransitioningContent;
                if (cursor != null)
                    return cursor;
            }
            return null;
        }

        protected override void OnDetaching()
        {
            AssociatedObject.SelectionChanged -= OnSelectionChanged;
        }
    }
}
