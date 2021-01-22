using AvaloniaSampleBinding.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaSampleBinding.ViewModels
{
    class AuthViewModel : BaseViewModel
    {

        public AuthViewModel(IChangeViewModel viewModelChanger) : base(viewModelChanger)
        {
        }

        public ILoginHandler LoginHandler { get; set; }

        public void Login()
        {
            LoginHandler?.UserLoggedIn();
            PopViewModel();
        }
    }
}
