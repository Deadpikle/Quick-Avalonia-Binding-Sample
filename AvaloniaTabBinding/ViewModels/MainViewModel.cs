using AvaloniaTabBinding.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace AvaloniaTabBinding.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        private ObservableCollection<ITabItem> _tabs;
        private int _selectedTabIndex;

        private int _tabNumber;

        public MainViewModel(IChangeViewModel viewModelChanger) : base(viewModelChanger)
        {
            _tabs = new ObservableCollection<ITabItem>()
            {
            };
            _tabNumber = 0;
            Tabs.CollectionChanged += Tabs_CollectionChanged;
        }

        private void Tabs_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            NotifyPropertyChanged(nameof(HasTabs));
        }

        public ObservableCollection<ITabItem> Tabs
        {
            get => _tabs;
            private set => _tabs = value;
        }

        public int SelectedTabIndex
        {
            get => _selectedTabIndex;
            set { _selectedTabIndex = value; NotifyPropertyChanged(); }
        }
        public bool HasTabs
        {
            get => Tabs.Count > 0;
        }

        public void AddTabTypeA()
        {
            Tabs.Add(new TabTypeAViewModel(++_tabNumber));
            SelectLastTab();
        }

        public void AddTabTypeB()
        {
            Tabs.Add(new TabTypeBViewModel(++_tabNumber));
            SelectLastTab();
        }

        public void CloseTab(ITabItem item)
        {
            if (!item.IsRunningAction)
            {
                item.Cleanup();
                Tabs.Remove(item);
            }
        }

        private void SelectLastTab()
        {
            if (Tabs.Count > 0)
            {
                SelectedTabIndex = Tabs.Count - 1;
                Tabs.Last().Initialize();
            }
        }

    }
}
