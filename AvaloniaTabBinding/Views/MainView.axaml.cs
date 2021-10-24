using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using Avalonia.VisualTree;
using AvaloniaTabBinding.ViewModels;

namespace AvaloniaTabBinding.Views
{
    public class MainView : UserControl
    {
        public MainView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public void TabClick(object sender, PointerPressedEventArgs e)
        {
            if (e.GetCurrentPoint(this).Properties.IsMiddleButtonPressed)
            {
                if (DataContext is MainViewModel && sender is IVisual)
                {
                    var button = (sender as IVisual)?.FindDescendantOfType<Button>();
                    button?.Command.Execute(button?.CommandParameter);
                }
            }
        }
    }
}
