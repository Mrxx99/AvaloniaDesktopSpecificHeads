using AvaloniaDesktopSpecificHeads.Services;

namespace AvaloniaDesktopSpecificHeads.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private readonly IPlatformService _platformService;

    public MainWindowViewModel(IPlatformService platformService)
    {
        _platformService = platformService;
    }

    public string Greeting => "Welcome to Avalonia!";

    public void ShowMessage() => _platformService.ShowMessage();
}
