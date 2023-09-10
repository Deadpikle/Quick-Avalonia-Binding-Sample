using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using Avalonia.VisualTree;
using AvaloniaTabBinding.ViewModels;

namespace AvaloniaTabBinding.Views
{
    public partial class MainView : UserControl
    {
        public MainView()
        {
            this.InitializeComponent();
        }

        public void TabClick(object sender, PointerPressedEventArgs e)
        {
            if (e.GetCurrentPoint(this).Properties.IsMiddleButtonPressed)
            {
                if (DataContext is MainViewModel && sender is Visual)
                {
                    var button = (sender as Visual)?.FindDescendantOfType<Button>();
                    button?.Command.Execute(button?.CommandParameter);
                }
            }
        }
    }
}
