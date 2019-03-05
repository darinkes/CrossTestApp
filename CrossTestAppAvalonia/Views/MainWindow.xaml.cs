using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using CrossTestApp.ViewModels;
using System.Diagnostics;

namespace CrossTestAppAvalonia.Views
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void Button_Click(object sender, RoutedEventArgs args)
        {
            Debug.WriteLine("Button_Click");
            var viewmodel = DataContext as MainWindowViewModel;
            viewmodel.MyProperty.Text = "Yeah!";
        }
    }
}
