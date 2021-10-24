using AvaloniaTabBinding.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaTabBinding.ViewModels
{
    class TabTypeBViewModel : BaseTabViewModel, ITabItem
    {
        private bool _isRunningAction;
        private int _tabNumber;

        public TabTypeBViewModel(int tabNumber)
        {
            _isRunningAction = false;
            _tabNumber = tabNumber;
        }

        public async void Initialize()
        {
            if (!HasInitialized)
            {
                HasInitialized = true;
                IsRunningAction = true;
                await Task.Delay(500);
                IsRunningAction = false;
            }
        }

        public bool HasInitialized { get; set; }

        public bool IsRunningAction
        {
            get => _isRunningAction;
            set { _isRunningAction = value; NotifyPropertyChanged(); }
        }

        public string TabName
        {
            get => "Tab Type B #" + _tabNumber;
        }

        public void Cleanup()
        {
        }
    }
}
