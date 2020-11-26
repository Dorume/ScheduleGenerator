using ScheduleGenerator.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleGenerator.ViewModels
{
    class MainViewModel : ViewModel
    {
        private string _Title = "Title";
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
    }
}
