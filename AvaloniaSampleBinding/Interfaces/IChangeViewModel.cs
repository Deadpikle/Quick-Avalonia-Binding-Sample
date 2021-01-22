using AvaloniaSampleBinding.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaSampleBinding.Interfaces
{
    interface IChangeViewModel
    {
        void PushViewModel(BaseViewModel model);
        void PopViewModel();
    }
}
