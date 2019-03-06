using System;
using System.Diagnostics;
using System.Windows;

using CrossTestApp.Models;
using CrossTestApp.ViewModels;

namespace CrossTestApp
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new MainWindowViewModel();

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Button_Click");
            var viewmodel = DataContext as MainWindowViewModel;
            viewmodel.DoSomething();
        }
    }
}