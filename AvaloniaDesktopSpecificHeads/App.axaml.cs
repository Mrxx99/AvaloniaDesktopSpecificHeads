using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using AvaloniaDesktopSpecificHeads.Services;
using AvaloniaDesktopSpecificHeads.ViewModels;
using AvaloniaDesktopSpecificHeads.Views;

namespace AvaloniaDesktopSpecificHeads;
public partial class App : Application
{
    private readonly IPlatformService _platformService;

    public App(IPlatformService platformService)
    {
        _platformService = platformService;
    }

    public App()
    {
        // required for designer/build
    }

    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            // Line below is needed to remove Avalonia data validation.
            // Without this line you will get duplicate validations from both Avalonia and CT
            ExpressionObserver.DataValidators.RemoveAll(x => x is DataAnnotationsValidationPlugin);
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel(_platformService),
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}