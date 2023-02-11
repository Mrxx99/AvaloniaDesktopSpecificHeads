using Avalonia.Controls;
using AvaloniaDesktopSpecificHeads.Services;

namespace AvaloniaDesktopSpecificHeads.Linux.Services;

internal class LinuxPlatformService : IPlatformService
{
    public void ShowMessage()
    {
        var window = new Window
        {
            Content = "This is Linux"
        };

        window.Show();
        // Call some Linux specific APIs
    }
}
