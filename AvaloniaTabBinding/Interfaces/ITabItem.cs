using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaTabBinding.Interfaces
{
    interface ITabItem
    {
        string TabName { get; }
        bool HasInitialized { get; set; }

        bool IsRunningAction { get; set; }

        /// <summary>
        /// Load any data async that needs to be loaded 
        /// outside the constructor
        /// </summary>
        void Initialize();

        /// <summary>
        /// Clean up anything necessary for the tab
        /// </summary>
        void Cleanup();
    }
}
