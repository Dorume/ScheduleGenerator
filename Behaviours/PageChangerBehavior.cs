using Microsoft.Xaml.Behaviors;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ScheduleGenerator.Behaviours
{
    class PageChangerBehavior : Behavior<ListView>
    {
        public static readonly DependencyProperty PageChangedProperty =
            DependencyProperty.Register(
                nameof(PageChanged),
                typeof(string),
                typeof(PageChangerBehavior),
                new PropertyMetadata(default(string))
                );

        [Description("Изменение страницы")]
        public string PageChanged
        {
            get => (string)GetValue(PageChangedProperty);
            set => SetValue(PageChangedProperty, value);
        }

        public PageChangerBehavior()
        {
            PageChanged = "/Views/Pages/SubjectsPage.xaml";
        }

        protected override void OnAttached()
        {
            AssociatedObject.SelectionChanged += OnSelectionChanged;
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string text = (AssociatedObject.SelectedItem as ListViewItem).Name;
            switch (text)
            {
                case "Subjects":
                    PageChanged = "/Views/Pages/SubjectsPage.xaml";
                    break;
                case "Teachers":
                    PageChanged = "/Views/Pages/TeachersPage.xaml";
                    break; ;
                case "Groups":
                    PageChanged = "/Views/Pages/GroupsPage.xaml";
                    break; ;
            }
        }

        protected override void OnDetaching()
        {
            AssociatedObject.SelectionChanged -= OnSelectionChanged;
        }
    }
}
