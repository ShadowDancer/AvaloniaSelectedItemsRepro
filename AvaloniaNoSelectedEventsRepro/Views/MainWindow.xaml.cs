using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaNoSelectedEventsRepro.ViewModels;

namespace AvaloniaNoSelectedEventsRepro.Views
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            (DataContext as MainWindowViewModel).Counter++;
        }
    }
}
