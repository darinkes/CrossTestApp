using Avalonia;
using Avalonia.Logging.Serilog;
using CrossTestApp.ViewModels;
using CrossTestAppAvalonia.Views;

namespace CrossTestAppAvalonia
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildAvaloniaApp().Start<MainWindow>(() => new MainWindowViewModel());
        }

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .UseReactiveUI()
                .LogToDebug();
    }
}
