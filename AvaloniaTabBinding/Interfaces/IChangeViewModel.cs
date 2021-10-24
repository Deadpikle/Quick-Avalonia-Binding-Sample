using AvaloniaTabBinding.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaTabBinding.Interfaces
{
    interface IChangeViewModel
    {
        void PushViewModel(BaseViewModel model);
        void PopViewModel();
    }
}
