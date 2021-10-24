using AvaloniaTabBinding.Helpers;
using AvaloniaTabBinding.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaTabBinding.ViewModels
{
    class BaseViewModel : ChangeNotifier
    {
        IChangeViewModel _viewModelChanger;

        public BaseViewModel(IChangeViewModel viewModelChanger)
        {
            _viewModelChanger = viewModelChanger;
        }

        public IChangeViewModel ViewModelChanger
        {
            get { return _viewModelChanger; }
            set { _viewModelChanger = value; }
        }

        #region IChangeViewModel

        public void PopViewModel()
        {
            _viewModelChanger?.PopViewModel();
        }

        public void PushViewModel(BaseViewModel model)
        {
            _viewModelChanger?.PushViewModel(model);
        }

        #endregion
    }
}
