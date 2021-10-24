using AvaloniaTabBinding.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaTabBinding.ViewModels
{
    class TabTypeAViewModel : BaseTabViewModel, ITabItem
    {
        private bool _isRunningAction;
        private int _tabNumber;

        public TabTypeAViewModel(int tabNumber)
        {
            _isRunningAction = false;
            _tabNumber = tabNumber;
        }

        public void Initialize()
        {
            if (!HasInitialized)
            {
                HasInitialized = true;
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
            get => "Tab Type A #" + _tabNumber;
        }

        public void Cleanup()
        {
        }
    }
}
