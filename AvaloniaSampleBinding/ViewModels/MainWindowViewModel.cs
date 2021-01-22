using AvaloniaSampleBinding.Helpers;
using AvaloniaSampleBinding.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaSampleBinding.ViewModels
{
    class MainWindowViewModel : ChangeNotifier, IChangeViewModel, ILoginHandler
    {
        private string _loginText;
        BaseViewModel _currentViewModel;
        Stack<BaseViewModel> _viewModels;

        public MainWindowViewModel()
        {
            _viewModels = new Stack<BaseViewModel>();
            var initialViewModel = new MainViewModel(this)
            {
                LoginHandler = this
            };
            _viewModels.Push(initialViewModel);
            CurrentViewModel = initialViewModel;
            _loginText = "We're not logged in :(";
        }

        public BaseViewModel CurrentViewModel
        {
            get { return _currentViewModel; }
            set { _currentViewModel = value; NotifyPropertyChanged(); }
        }

        public string LoginText
        {
            get => _loginText;
            set { _loginText = value; NotifyPropertyChanged(); }
        }

        #region IChangeViewModel

        public void PushViewModel(BaseViewModel model)
        {
            _viewModels.Push(model);
            CurrentViewModel = model;
        }

        public void PopViewModel()
        {
            if (_viewModels.Count > 1)
            {
                _viewModels.Pop();
                CurrentViewModel = _viewModels.Peek();
            }
        }

        #endregion

        public void UserLoggedIn()
        {
            // here!
            LoginText = "We logged in!";
        }

        public void UserLoggedOut()
        {
            // here!
        }
    }
}
