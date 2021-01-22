using AvaloniaSampleBinding.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaSampleBinding.ViewModels
{
    class MainViewModel : BaseViewModel
    {

        public MainViewModel(IChangeViewModel viewModelChanger) : base(viewModelChanger)
        {
        }

        public ILoginHandler LoginHandler { get; set; }

        public void GoToAuth()
        {
            PushViewModel(new AuthViewModel(ViewModelChanger) { LoginHandler = LoginHandler });
        }
    }
}
